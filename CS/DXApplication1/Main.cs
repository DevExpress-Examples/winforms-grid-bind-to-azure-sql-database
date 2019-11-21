using DevExpress.XtraBars.Ribbon;
using DXApplication.Data;

namespace DXApplication {
    public partial class Main : RibbonForm {
        public Main() {
            InitializeComponent();

            gridView.OptionsView.RowAutoHeight = true;
        }
        async void BindToDataTable(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView.LoadingPanelVisible = true;
            gridControl.DataSource = await DataTableProvider.Instance.GetDataAsync();
            gridView.BestFitColumns();
            gridView.LoadingPanelVisible = false;
        }
        async void BindToSqlDataSource(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView.LoadingPanelVisible = true;
            gridControl.DataSource = await SqlDataSourceProvider.Instance.GetDataAsync();
            gridControl.DataMember = "AzureQuery";
            gridView.BestFitColumns();
            gridView.LoadingPanelVisible = false;
        }
        async void BindToEF(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView.LoadingPanelVisible = true;
            gridControl.DataSource = await EFDataProvider.Instance.GetDataAsync();
            gridView.BestFitColumns();
            gridView.LoadingPanelVisible = false;
        }
    }
}
