using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface IDocumentRepository
    {
        Document Find(int docid);
        List<Document> Search(string term);
        Document Add(Document document);
        List<Document> GetAll();
        void Delete(Document document);


    }
}
