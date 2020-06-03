using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BadgerData;
using DataLayer.Entities;

namespace Weaselware.InventoryFerret
{
    public class ResourceRepository
    {
        readonly BadgerDataModel _context;

        public ResourceRepository()
        {
            _context = new BadgerDataModel();
        }

        public  Document Find(int docID)
        {
            return  _context.Document.Find(docID);
        }
    }
}
