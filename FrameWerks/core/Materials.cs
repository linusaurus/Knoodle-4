#region Copyright (c) 2010 WeaselWare Software
/************************************************************************************
'
' Copyright  2010 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2010 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'***********************************************************************************/
#endregion

using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;


namespace FrameWorks
{
   public class SourceManager
   {
       
      private static Dictionary<int, SourceMaterial> m_ComponentSource = new Dictionary<int,SourceMaterial>();
      private static string connectionString = string.Empty;
      public static Dictionary<int, SourceMaterial> ComponentsSource
      {get { return m_ComponentSource; } }

      public static void SetConnectionString(string con)
      {
          connectionString = con;
      }
      
      public static void Load(bool useComponentLibrary)
      {
         string ConString = @"Password=Kx09a32x;Persist Security Info=True;User ID=sa;Initial Catalog=Badger;Data Source=192.168.10.3";
        // string ConString = connectionString;
         SqlConnection con = new SqlConnection(ConString);
        
         SqlCommand  cmd = con.CreateCommand();
         cmd.CommandText = @"select Componentid,
                                    itemname,
                                    itemdescription,
                                    cost,
                                    UID,
                                    Weight,
                                    Waste,
                                    Markup,
                                    SupplierID FROM Component";
         con.Open();
         SqlDataReader  reader = cmd.ExecuteReader();

         while (reader.Read())
         {
            SourceMaterial material = new SourceMaterial();
            // ItemID-ComponentNum
            material.ItemID = reader.GetInt32(0);
            if(!reader.IsDBNull(1))material.MaterialName = reader.GetString(1);
            else{material.MaterialName = string.Empty;}
            // Material Description   
            if(!reader.IsDBNull(2)) material.MaterialDescription = reader.GetString(2);
            else{material.MaterialDescription = string.Empty;}
            // Cost  
            if (!reader.IsDBNull(3))material.Cost = reader.GetDecimal(3);
            // Materials UOM (unitof measure)           
            if(!reader.IsDBNull(4)) material.UOM = reader.GetInt32(4);
            else{material.UOM = 0;}
            // Wieght  
            if (!reader.IsDBNull(5)) material.Weight = reader.GetDecimal(5);
            // Waster
            if (!reader.IsDBNull(6))material.Waste = reader.GetDecimal(6);
            // Markup
            if (!reader.IsDBNull(7)) material.MarkUp = reader.GetDecimal(7);
            // SupplierID 
            if (!reader.IsDBNull(8)) material.SupplierID  = reader.GetInt32 (8);
 
            m_ComponentSource.Add(reader.GetInt32(0), material);

         }
         con.Close();

      }
   }

   public class LaborManager
   {
       private static Dictionary<int, Routing> m_laborSource = new Dictionary<int, Routing >();
       private static string connectionString = string.Empty;
       public static Dictionary<int, Routing> LaborSource
       { get { return m_laborSource; } }

       public static void SetConnectionString(string con)
       {
           connectionString = con;
       }
       public static void Load()
       {
//           string ConString = @"Password=Kx09a32x;Persist Security Info=True;User ID=sa;Initial Catalog=badger;Data Source=DATASERVER";
//           //string ConString = connectionString;
//           SqlConnection con = new SqlConnection(ConString);

//           SqlCommand cmd = con.CreateCommand();
//           cmd.CommandText = @"select TaskID,
//                                      TaskName,
//                                      TaskDescription,
//                                      TaskClass,
//                                      Rate,
//                                      UOM,
//                                      Factor From Task";
//           con.Open();
//           SqlDataReader reader = cmd.ExecuteReader();

//           while (reader.Read())
//           {
//               FrameWorks.Routing  routing = new Routing();
//               // routingID-Labor Component ID
//               if (!reader.IsDBNull(0)) routing.RoutingID = reader.GetInt32(0);
//               else { routing.RoutingID = 0; }
//               if (!reader.IsDBNull(1)) routing.RoutingName = reader.GetString(1);
//               else { routing.RoutingName = string.Empty ; }
//               if (!reader.IsDBNull(2)) routing.RoutingDescription = reader.GetString(2);
//               else { routing.RoutingDescription = string.Empty; }
//               if (!reader.IsDBNull(3)) routing.Rate = reader.GetDecimal(3);
//               else { routing.Rate = decimal.Zero ; }
//               if (!reader.IsDBNull(4)) routing.Amount  = reader.GetDecimal(4);
//               else { routing.Amount  = decimal.Zero; }
//               if (!reader.IsDBNull(5)) routing.CostFactor = reader.GetInt32(5);
//               else { routing.CostFactor  = 0; }

//               m_laborSource.Add(routing.RoutingID, routing);
              
//           }
//           con.Close(); 

       }

   }
}
