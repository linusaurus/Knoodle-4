using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Runtime.Serialization;
using System.Text;

namespace FrameWorks
{
    

        [Serializable]
        public class MakeFileException : System.Exception
        {
            public string MakeFileName;

            public MakeFileException(string makefile)
            {
                this.MakeFileName = makefile;
               
            }

            
        }

    
}
