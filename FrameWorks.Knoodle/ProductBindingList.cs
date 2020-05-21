using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace Weaselware.Knoodle
{
    public class ProductBindingList<ProductDto> : BindingList<ProductDto> 
    {

       
        protected override void SetItem(int index, ProductDto item)
        {
            ProductDto oldMyInt = this.Items[index];
            ProductDto newMyInt = item;

            if (myIntOldNew != null)
            {
                myIntOldNew(oldMyInt, newMyInt);
            }

            base.SetItem(index, item);
        }

        

        protected override void RemoveItem(int itemIndex)
        {
            ProductDto deletedItem = this.Items[itemIndex];

            if (BeforeRemove != null)
            {
                BeforeRemove(deletedItem);
            }

            base.RemoveItem(itemIndex);
        }

        public delegate void myIntDelegateChanged(ProductDto oldItem, ProductDto newItem);
        public event myIntDelegateChanged myIntOldNew;

        public delegate void myIntDelegate(ProductDto deletedItem);
        public event myIntDelegate BeforeRemove;


    }
}
