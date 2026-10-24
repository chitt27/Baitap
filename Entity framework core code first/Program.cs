using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVien
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try
            {
                using var db = new QLSVContext();
                db.Database.Migrate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tạo được cơ sở dữ liệu: " + ex.Message,
                    "Lỗi kết nối MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new Main());
        }
    }
}
