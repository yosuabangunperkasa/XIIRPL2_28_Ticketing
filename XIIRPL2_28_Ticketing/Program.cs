using XIIRPL2_28_Ticketing.MasterForm;

namespace XIIRPL2_28_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //frmlogin formlogin = new frmlogin();
            //formlogin.Show();
           //MasterBandara bandara = new MasterBandara();
           //bandara.Show();
            MasterMaskpaics masterMaskpaics = new MasterMaskpaics();
            masterMaskpaics.Show();
            //FormMasterKodePromo formMasterKodePromo = new FormMasterKodePromo();
            //formMasterKodePromo.Show();

            //MasterJadwalPenerbangan masterJadwalPenerbangan = new MasterJadwalPenerbangan();
            //masterJadwalPenerbangan.Show();
            Application.Run();
 
        }
    }
}