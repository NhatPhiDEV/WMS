using System.Windows.Media.Imaging;
using MediatR;
using WMS.Application.Common;
using WMS.Application.DTO;
using WMS.Application.Features.Locations.Queries.GetById;
using WMS.Application.Features.Locations.Queries.GetLocations;
using WMS.Domain.Models;
using WMS.UI.Common.Extensions;
using WMS.UI.Common.Messages;
using TextMessage = WMS.UI.Common.Messages.TextMessage.FormLocationManagement;


namespace WMS.UI.Forms
{
    public partial class FormLocationManagement : Form
    {
        private readonly IMediator _mediator;
        public bool IsLoadingData;
        public delegate void AddOrUpdateLocationEventHandler(Location? location);
        public event AddOrUpdateLocationEventHandler? AddOrUpdateLocationEvent;

        public enum GvLocationsCol
        {
            LocationId,
            LocationCode,
            LocationName,
            Capacity,
            ZoneId,
            ZoneName,
            PointX,
            PointY,
            PointZ,
            IsActive,
            CreatedAt,
            UpdatedAt,
            Update,
            Remove
        }

        public FormLocationManagement(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        private async void FormLocationManagement_Load(object sender, EventArgs e)
        {
            await Init();
        }

        private async Task Init()
        {
            await LoadLocations();
            LoadPageSize();
            TbSearch.Text = null;
        }

        #region Init

        private void LoadPageSize()
        {
            IsLoadingData = true;

            var datasource = new List<ComboBoxItem>
            {
                new()
                {
                    Key = 10,
                    Val = 10
                },
                new()
                {
                    Key = 50,
                    Val = 50,
                },
                new()
                {
                    Key = 100,
                    Val = 100,
                },
                new()
                {
                    Key = 500,
                    Val = 500,
                }
            };
            CbPageSize.SetDataSourceWithMembers(datasource, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));

            IsLoadingData = false;

        }

        private async Task LoadLocations(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            GvLocations.DataSource = null;
            GvLocations.Rows.Clear();

            var query = new GetLocationsQuery(searchTerm, page, pageSize);
            var locations = await _mediator.Send(query);
            TbPageSearch.Text = locations.Page.ToString();
            BtnNext.Enabled = locations.HasNextPage;
            BtnPrev.Enabled = locations.HasPreviousPage;

            GvLocations.AutoGenerateColumns = false;

            GvLocations.Columns[nameof(GvLocationsCol.LocationId)]!.DataPropertyName = nameof(LocationDto.LocationId);
            GvLocations.Columns[nameof(GvLocationsCol.LocationCode)]!.DataPropertyName = nameof(LocationDto.LocationCode);
            GvLocations.Columns[nameof(GvLocationsCol.LocationName)]!.DataPropertyName = nameof(LocationDto.LocationName);
            GvLocations.Columns[nameof(GvLocationsCol.Capacity)]!.DataPropertyName = nameof(LocationDto.Capacity);
            GvLocations.Columns[nameof(GvLocationsCol.ZoneId)]!.DataPropertyName = nameof(LocationDto.ZoneId);
            GvLocations.Columns[nameof(GvLocationsCol.ZoneName)]!.DataPropertyName = nameof(LocationDto.ZoneName);
            GvLocations.Columns[nameof(GvLocationsCol.PointX)]!.DataPropertyName = nameof(LocationDto.PointX);
            GvLocations.Columns[nameof(GvLocationsCol.PointY)]!.DataPropertyName = nameof(LocationDto.PointY);
            GvLocations.Columns[nameof(GvLocationsCol.PointZ)]!.DataPropertyName = nameof(LocationDto.PointZ);
            GvLocations.Columns[nameof(GvLocationsCol.IsActive)]!.DataPropertyName = nameof(LocationDto.IsActive);
            GvLocations.Columns[nameof(GvLocationsCol.CreatedAt)]!.DataPropertyName = nameof(LocationDto.CreatedAt);
            GvLocations.Columns[nameof(GvLocationsCol.UpdatedAt)]!.DataPropertyName = nameof(LocationDto.UpdatedAt);

            GvLocations.DataSource = locations.Items;


        }

        private async Task LoadLocationsWithFilters(bool hasPrev = false, bool hasNext = false)
        {
            var search = string.IsNullOrEmpty(TbSearch.Text.Trim()) ? "" : TbSearch.Text;
            var pageSearch = TbPageSearch.Text;
            if (string.IsNullOrEmpty(pageSearch)) return;

            if (CbPageSize.SelectedItem is not ComboBoxItem pageSizeSelected) return;

            var pageSize = (int)pageSizeSelected.Key;
            int.TryParse(pageSearch, out var page);

            if (page < 1) return;

            page = hasPrev ? page - 1 : hasNext ? page + 1 : page;

            await LoadLocations(searchTerm: search, page: page, pageSize: pageSize);
        }

        #endregion

        #region Pangination
        private async void TbPageSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LoadLocationsWithFilters();
            }
        }

        private async void CbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsLoadingData)
            {
                await LoadLocationsWithFilters();
            }
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            await LoadLocationsWithFilters(hasNext: true);
        }

        private async void BtnPrev_Click(object sender, EventArgs e)
        {
            await LoadLocationsWithFilters(hasPrev: true);
        }
        #endregion

        #region Action
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrUpdateLocation(_mediator);
            form.SetOwner(this);
            AddOrUpdateLocationEvent!.Invoke(null);
            form.LocationModified += LocationModified;
            form.ShowDialog();
        }

        private async void LocationModified(object sender, EventArgs e)
        {
            await Init();
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private async void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LoadLocationsWithFilters();
            }
        }

        private async void GvLocations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e is not { RowIndex: >= 0, ColumnIndex: >= 0 }) return;

            switch (GvLocations.Columns[e.ColumnIndex].Name)
            {
                case nameof(GvLocationsCol.Update): 
                    await UpdateLocationHandle(e);
                    return;
                case nameof(GvLocationsCol.Remove):
                {
                    //await RemoveProductHandle(e);
                    return;
                }
            }
        }

        private async Task UpdateLocationHandle(DataGridViewCellEventArgs e)
        {
            var row = GvLocations.Rows[e.RowIndex];
            var locationIdValueCell = row.Cells[nameof(GvLocationsCol.LocationId)]?.Value?.ToString();

            if (!int.TryParse(locationIdValueCell, out int locationId))
            {
                MessageBox.Show(
                    TextMessage.Location.InvalidInput,
                    CaptionMessage.System.Warning,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }

            var query = new GetLocationByIdQuery(locationId);
            var location = await _mediator.Send(query);

            var form = new FormAddOrUpdateLocation(_mediator);
            form.SetOwner(this);
            AddOrUpdateLocationEvent!.Invoke(location);
            form.LocationModified += LocationModified;
            form.ShowDialog();

        }

        private bool ValidateRow(DataGridViewCellEventArgs e)
        {
            var row = GvLocations.Rows[e.RowIndex];
            var locationIdValueCell = row.Cells[nameof(GvLocationsCol.LocationId)]?.Value?.ToString();
            return int.TryParse(locationIdValueCell, out int locationId);
        }
    }
}
