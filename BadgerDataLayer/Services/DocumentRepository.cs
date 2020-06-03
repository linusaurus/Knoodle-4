using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Entities;
using DataLayer.Interfaces;

namespace DataLayer.Services
{
    public class DocumentRepository : IDocumentRepository
    {
        BadgerDataModel _context = new BadgerDataModel();

        public DocumentRepository(BadgerDataModel context)
        {
            _context = context;
        }

        public Document Add(Document document)
        {
            _context.Document.Add(document);
            _context.SaveChanges();
            return document;
        }

        public void Delete(Document document)
        {
            _context.Document.Remove(document);
            _context.SaveChanges();
        
        }

        public Document Find(int docid)
        {
            return _context.Document.Find(docid);
        }

        public List<Document> GetAll()
        {
            return _context.Document.ToList();
        }

        public List<Document> Search(string term)
        {
            return _context.Document.Where(e => e.Description.Contains(term)).ToList() ;
        }
    }
}
