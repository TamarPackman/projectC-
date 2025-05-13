using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int id { get; set; }
        public int _productId { get; set; }
        public int _quantityForSale { get; set; }
        public double _salePrice { get; set; }
        public bool _isForClubMembersOnly { get; set; }
        public DateTime _dateStartSale { get; set; }
        public DateTime _dateEndSale { get; set; }

        public Sale()
        {
            id = 0;
            _productId = 0;
            _quantityForSale = 0;
            _salePrice = 0;
            _isForClubMembersOnly = false;
            _dateStartSale = new DateTime();
            _dateEndSale = new DateTime();
        }
        public Sale(int id, int productId, int quantityForSale, double salePrice, bool isForClubMembersOnly, DateTime dataStartSale, DateTime dataEndSale)
        {
            this.id = id;
            _productId = productId;
            _quantityForSale = quantityForSale;
            _salePrice = salePrice;
            _isForClubMembersOnly = isForClubMembersOnly;
            _dateStartSale = dataStartSale;
            _dateEndSale = dataEndSale;
        }
        public Sale( int productId, int quantityForSale, double salePrice, bool isForClubMembersOnly, DateTime dataStartSale, DateTime dataEndSale)
        {
            _productId = productId;
            _quantityForSale = quantityForSale;
            _salePrice = salePrice;
            _isForClubMembersOnly = isForClubMembersOnly;
            _dateStartSale = dataStartSale;
            _dateEndSale = dataEndSale;
        }

        public override string ToString() => Tools.ToStringProperty(this);
    }
}
