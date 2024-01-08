using OnlineAuction.Models;

namespace OnlineAuction.Dtos.ProductDtos
{
    public class AddProductDto : IMapFrom<Product>
    {
        #region properties

        ///<summary>
        ///Product name(in UTF8 format)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        ///Product price 
        ///</summary>
        public float Price { get; set; }

        ///<summary>
        ///product description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        ///product image path
        ///</summary>
        public string ImgPath { get; set; }        

        ///<summary>
        ///Array of categories
        ///</summary>             
        public string[] Categories { get; set; }
        #endregion
    }
}