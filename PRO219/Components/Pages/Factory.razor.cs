using PRO219.Components.Pages.Dialog;
using Radzen;
using Radzen.Blazor;

namespace PRO219.Components.Pages
{
    public partial class Factory
    {
        public RadzenDataGrid<Models.Factory> grid;
        public IEnumerable<Models.Factory> factorydata = new List<Models.Factory>()
{
    new Models.Factory
    {
        FactoryId = Guid.NewGuid(),
        FactoryName = "Factory A",
        Note = "This is Factory A",
        IsDeleted = false,
        CreateDate = DateTime.Now,
        CreateBy = Guid.NewGuid(),
        UpdateDate = null,
        UpdateBy = null
    },
    new Models.Factory
    {
        FactoryId = Guid.NewGuid(),
        FactoryName = "Factory B",
        Note = "This is Factory B",
        IsDeleted = false,
        CreateDate = DateTime.Now,
        CreateBy = Guid.NewGuid(),
        UpdateDate = DateTime.Now,
        UpdateBy = Guid.NewGuid()
    }
};

        private async Task InsertDialog()
        {
            try
            {
                var rs = await DialogService.OpenAsync<FactoryDialog>($"Insert new Factory", null, new DialogOptions()
                {
                    Width = "50%",
                    Height = "50%",
                    ShowClose = true,
                    CloseDialogOnEsc = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
