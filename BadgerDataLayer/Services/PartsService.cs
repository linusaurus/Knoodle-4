using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Services;

namespace DataLayer.Services
{
    public class PartsService : IPartsService , IDisposable
    {
        BadgerDataModel _context;
        String partEditorName = string.Empty;

        public PartsService(BadgerDataModel ctx)
        {
            _context = ctx;
            IEmployeeService empService = new EmployeeService(_context);           
           // partEditorName = empService.FullName(Globals.CurrentLoggedUserID);
            
        }

        public List<UnitOfMeasure> Units()
        {
           return  _context.UnitOfMeasure.ToList();
        }

        public bool AssociateSKU(Part part, string sku)
        {
            bool result = false;
            if (part == null){ return false; }
            var originalPart = _context.Part.Find(part.PartID);
            originalPart.Sku = sku;
            try
            {
                _context.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
           
            return result;            
        }

        public void Delete(Part part)
        {
            
            _context.Part.Remove(part) ;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
            }
            // free native resources if there are any.
        }


        public bool Exist(int PartID)
        {
            bool result = false;
            if (_context.Part.Any(c => c.PartID == PartID))
            {
                result = true;
            }

            return result;
        }

        public List<Part> SearchParts(string searchTerm ,SearchOptions option )
        {
            if (option == SearchOptions.Contains)
            {
                return _context.Part.Where(p => p.ItemDescription.Contains( searchTerm)).ToList();
            }
            else if (option == SearchOptions.StartsWith)
            {
                return _context.Part.Where(p => p.ItemDescription.StartsWith(searchTerm)).ToList();
            }
            else
            {
                return null;
            }


        }
        // Return Part of null if not found
        public Part Find(int PartID)
        {
            if (String.IsNullOrEmpty(PartID.ToString()))
            {
                return null;
            }
            return _context.Part.Include(g=> g.DocumentParts).Where(p => p.PartID == PartID).FirstOrDefault();
        }

        public Part FindBySKU(string sku)
        {
            return _context.Part.Where(p => p.Sku == sku).FirstOrDefault();
        }

        public List<Part> GetAllParts()
        {
            return _context.Part.ToList();
        }

        public List<Part> GetManufacturerParts(int ManuID)
        {
            return _context.Part.Where(p => p.ManuId == ManuID).ToList();
        }

        public List<Part> GetSupplierParts(int supplierID)
        {
            return _context.Part.Where(p => p.SupplierId == supplierID).ToList();
        }

        public void InsertOrUpdate(PurchaseOrder order)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        /// <summary>
        /// Return new fleshed out part not saved
        /// </summary>
        /// <returns></returns>
        public Part New()
        {
            Part result = new Part();
            result.Carblevel = "NA";
            result.SupplierDescription = "-";
            result.Carbtrack = false;
            result.Cost = 0.0m;
            result.PartNum = string.Empty;
            result.DateAdded = DateTime.Today;
            result.ItemName = string.Empty;
            result.UseSupplierNameFlag = false;
            result.Cost= 0.0m;
            result.Uop = "Ea";
            result.UnitToPurchaseFactor = 0.0m;
            result.UID = 1;
            result.ManuId = 1;
            result.Uopcost = 0.0m;
            result.Sku = string.Empty;
            result.Waste = 0.0m;
            result.Weight = 0.0m;
            result.AddedBy = partEditorName;
            result.MarkUp = 0.0m;
                
            return result;
        }

        /// <summary>
        /// TODO this should be moved to another repo of data service
        /// </summary>
        /// <returns></returns>
        public List<Manu> Manufacturers()
        {
            return _context.Manu.ToList();
        }
        /// <summary>
        /// TODO this shuld be moved tomore general list data source
        /// </summary>
        /// <returns></returns>
        public List<Category> PartCategory()
        {
            return _context.Category.ToList();
        }

        public void DeleteResource(Document document, Part part)
        {          
            _context.DocumentParts.Remove(new DocumentParts { DocId = document.DocId, PartID = part.PartID });
           
            _context.Document.Remove(document);
            _context.SaveChanges();
        }

        public void AddResource(Document document, Part part)
        {
            if(document.DocId == 0)
            {
                _context.Document.Add(document);
                _context.SaveChanges();
            }
            part.DocumentParts.Add(new DocumentParts { PartID = part.PartID, DocId = document.DocId });
            _context.SaveChanges();
        }

        public Part Add(Part part)
        {
            if (part.PartID != 0)
            {
                _context.Part.Add(part);
                _context.SaveChanges();
                
            }
            return part;
        }

        
    }
}
