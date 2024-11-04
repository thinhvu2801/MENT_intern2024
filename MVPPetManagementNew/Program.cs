using CRUDWinFormsMVP.Views;
using MVPPetManagement.Views;
using System.Windows.Forms;
using System;
using MVPPetManagement.Presenters;
using MVPPetManagement._Repositories;
using MVPPetManagement.Models;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        string sqlConnectionString = @"Data Source=THINHVUMINH\SQLEXPRESS;Initial Catalog=VeterinaryDb;Integrated Security=True;TrustServerCertificate=True";

        // Tạo main view
        IMainView mainView = new MainView();

        // Tạo presenter và liên kết với main view
        MainPresenter presenter = new MainPresenter(mainView, sqlConnectionString);

        // Hiển thị main view
        Application.Run((Form)mainView);


    }
}