using System.Text;

namespace WMS.UI.Common.Messages
{
    public struct TextMessage
    {
        public struct  FormDashboard
        {
            public const string ExecuteSelected = "Bạn có chắc chắn muốn thực thi các tiến trình đã chọn?";
            public const string ExecuteAll = "Bạn có chắc chắn muốn thực thi tất cả tiến trình?";
            public const string CancelExecutedSuccessfully = "Dừng tiến trình thành công!";
            public const string GetStatusFromPlcUnsuccessfully = "Không thể lấy được kết quả xử lý từ PLC!";
            public const string ConfirmDeleteAllProcess = "Bạn có chắc chắn muốn khởi tạo lại danh sách tiến trình?";
            public const string ConfirmDeleteProcess = "Bạn có chắc chắn muốn loại bỏ các tiến trình đã chọn?";
            public const string DeleteProcessSuccessfully = "Tiến trình đã bị loại bỏ!";

            public static string ProcessName(string transactionType, string sku)
            {
                var sb = new StringBuilder();
                sb.Append("Đang xử lý tác vụ ");
                sb.Append(transactionType);
                sb.Append(" của mã hàng ");
                sb.Append(sku);
                return sb.ToString();
            }

            public static string ExecutedSuccessfully(int count)
            {
                var sb = new StringBuilder();
                sb.Append("Thực thi thành công ");
                sb.Append(count);
                sb.Append(" tác vụ!");

                return sb.ToString();
            }

            public struct Product
            {
                public const string NotFound = "Không tìm thấy hàng hóa! Vui lòng kiểm tra lại";
                public const string NotExists = "Hàng hóa không tồn tại trong hệ thống! ";
                public const string Create = "Bạn có muốn tạo mới không?";
                public const string SkuNotMatch = "Mã barcode không khớp! Vui lòng kiểm tra lại!";
                
            }

            public struct Validate
            {
                public const string InvalidSku = "Vui lòng điền mã hàng!";
                public const string InvalidLocation = "Vui lòng chọn lệnh!";
                public const string InvalidInventorTransType = "Vui lòng chọn vị trí!";
            }
        }

        public struct FormProductManagement
        {
            public struct Product
            {
                public const string InvalidInput = "Vui lòng chọn dòng cần xóa!";
                public static string ConfirmDeleteAction(string? sku)
                {
                    var sb = new StringBuilder();
                    sb.Append("Bạn có chắc chắn muốn xóa mã hàng ");
                    sb.Append(sku);
                    sb.Append(" này không?");
                    return sb.ToString();
                }
            }
            public const string DeleteSuccessfully = "Xóa dữ liệu thành công!";

        }

        public struct FormLocationManagement
        {
            public struct Location
            {
                public const string InvalidInput = "Vui lòng chọn dòng cần xóa!";
                public static string ConfirmDeleteAction(string? sku)
                {
                    var sb = new StringBuilder();
                    sb.Append("Bạn có chắc chắn muốn xóa mã hàng ");
                    sb.Append(sku);
                    sb.Append(" này không?");
                    return sb.ToString();
                }
            }
            public const string DeleteSuccessfully = "Xóa dữ liệu thành công!";

        }
    }
}
