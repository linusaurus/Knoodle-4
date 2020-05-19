using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Service
{
    public interface IPartsService
    {
        int PartCount { get; set; }
        Dictionary<int, Part> Parts { get; }

        Part GetPart(int partID);
        void LoadParts();
    }
}