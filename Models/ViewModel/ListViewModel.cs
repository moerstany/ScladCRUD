using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScladCRUD.Models.ViewModel
{
    public class ListViewModel
    {
        public int IdCatalog { get; set; }


        
        public int Price { get; set; }

       
        public string Description { get; set; }

        
        public string ProductName { get; set; }
        
        public string Articul { get; set; }
        public int Cost { get; set; }
        
        public string ProductPic { get; set; }
        
        public int Margin { get; set; }

    }
}
