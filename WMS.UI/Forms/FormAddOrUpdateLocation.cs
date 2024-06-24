using MediatR;
using WMS.Application.Common;
using WMS.Application.Features.Zones.Queries.GetMultiple;
using WMS.Domain.Models;
using WMS.UI.Common.Extensions;

namespace WMS.UI.Forms
{
    public partial class FormAddOrUpdateLocation : Form
    {
        private readonly IMediator _mediator;
        public delegate void LocationModifiedEventHandler(object sender, EventArgs e);
        public event LocationModifiedEventHandler? LocationModified;
        private Location? _locationTemp;

        public FormAddOrUpdateLocation(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();
        }

        public void SetOwner(Form owner)
        {
            this.Owner = owner;

            if (this.Owner is FormLocationManagement locationManagement)
            {
                locationManagement.AddOrUpdateLocationEvent += EventFormLocationManagement;
            }
        }

        private async void EventFormLocationManagement(Location? location)
        {
            await Init();
            if (location == null) return;
            TbLocationCode.Text = location.LocationCode;
            TbLocationName.Text = location.LocationName;
            NumCapacity.Value = location.Capacity;
            CbZones.SelectedValue = location.ZoneId;
            TbPointX.Text = location.PointX;
            TbPointY.Text = location.PointY;
            TbPointZ.Text = location.PointZ;

            _locationTemp = location;
        }

        private async Task Init()
        {
            // Clear text
            TbLocationCode.Text = null;
            TbLocationName.Text = null;
            NumCapacity.Value = 1;
            TbPointX.Text = null;
            TbPointY.Text = null;
            TbPointZ.Text = null;

            CbZones.DataSource = null;

            await LoadZones();
        }

        private async Task LoadZones()
        {
            var query = new GetMultipleZoneQuery();
            var zones = await _mediator.Send(query);
            var dataSource = zones
                .Select(zone => new ComboBoxItem
                {
                    Key = zone.ZoneId, 
                    Val = zone.ZoneName
                }).ToList();

            CbZones.SetDataSourceWithMembers(dataSource, nameof(ComboBoxItem.Key), nameof(ComboBoxItem.Val));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LocationModified?.Invoke(this, EventArgs.Empty);
        }

        private async void FormAddOrUpdateLocation_Load(object sender, EventArgs e)
        {
            await Init();
        }
    }
}
