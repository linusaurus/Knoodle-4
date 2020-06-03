using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataLayer.Entities.Configuration;
using DataLayer.Configuration;

namespace DataLayer.Entities
{
    public partial class BadgerDataModel : DbContext
    {

        
        public BadgerDataModel()
        {
        }

        //public BadgerDataModel()
        //  : base()
        //{

        //}

        public BadgerDataModel(DbContextOptions<BadgerDataModel> options)
            : base(options)
        {

        }

        public virtual DbSet<AccountType> AccountType { get; set; }
       
        public virtual DbSet<Assembly> Assembly { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Claim> Claim { get; set; }
        public virtual DbSet<ClaimDocument> ClaimDocument { get; set; }
        public virtual DbSet<ClaimItem> ClaimItem { get; set; }

        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentParts> DocumentParts { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Finish> Finish { get; set; }
        //public virtual DbSet<Globals> Globals { get; set; }
        public virtual DbSet<Import> Import { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        //public virtual DbSet<InventoryView> InventoryView { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Manu> Manu { get; set; }
        public virtual DbSet<Nfrc> Nfrc { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<OrderReciept> OrderReciept { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PartCategory> PartCategory { get; set; }
        public virtual DbSet<PartClass> PartClass { get; set; }
        public virtual DbSet<PartType> PartType { get; set; }
        public virtual DbSet<PartTypes> PartTypes { get; set; }
        public virtual DbSet<OrderFee> OrderFee { get; set; }
       
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceVersion> ResourceVersion { get; set; }
       
        public virtual DbSet<PurchaseLineItem> PurchaseLineItem { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<Purchasers> Purchasers { get; set; }
        public virtual DbSet<Recieving> Recieving { get; set; }
        public virtual DbSet<Sdapcd> Sdapcd { get; set; }
        public virtual DbSet<ShipBy> ShipBy { get; set; }
        public virtual DbSet<StockBill> StockBill { get; set; }
        public virtual DbSet<StockBillItem> StockBillItem { get; set; }
        public virtual DbSet<SubAssembly> SubAssembly { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TransActionType> TransActionType { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
        public virtual DbSet<UnitOfPurchase> UnitOfPurchase { get; set; }
        public virtual DbSet<WorkCenter> WorkCenter { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=192.168.10.3;database=Badger;uid=sa;pwd=Kx09a32x;");
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AccountTypeConfig());
            modelBuilder.ApplyConfiguration(new AssemblyConfig());
            modelBuilder.ApplyConfiguration(new AttachmentConfig());
            modelBuilder.ApplyConfiguration(new AssetConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ClaimConfig());
            modelBuilder.ApplyConfiguration(new ClaimDocumentConfig());
            modelBuilder.ApplyConfiguration(new ClaimItemConfig());
            modelBuilder.ApplyConfiguration(new DocumentPartConfig());
            modelBuilder.ApplyConfiguration(new PartConfig());
            modelBuilder.ApplyConfiguration(new AssemblyConfig());
            modelBuilder.ApplyConfiguration(new SubAssemblyConfig());
            modelBuilder.ApplyConfiguration(new DocumentConfig());
            modelBuilder.ApplyConfiguration(new StockBillItemConfig());
            modelBuilder.ApplyConfiguration(new InventoryConfig());
            modelBuilder.ApplyConfiguration(new UnitOfMeasureConfig());
            modelBuilder.ApplyConfiguration(new UnitOfPurchaseConfig());
            modelBuilder.ApplyConfiguration(new PurchaseOrderConfig());
            modelBuilder.ApplyConfiguration(new OrderFeeConfig());
            modelBuilder.ApplyConfiguration(new ResourceConfig());
            modelBuilder.ApplyConfiguration(new ResourceVersionConfig());

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                
            });

            modelBuilder.Entity<Finish>(entity =>
            {
                entity.Property(e => e.FinishId).HasColumnName("FinishID");

               
            });

           

            modelBuilder.Entity<Import>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("import");

               
            });

          

            modelBuilder.Entity<InventoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Inventory_View");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.PartID).HasColumnName("PartID");

                entity.Property(e => e.StockLevel)
                    .HasColumnName("Stock Level")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jobdesc)
                    .HasColumnName("jobdesc")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Jobname)
                    .HasColumnName("jobname")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Jobnumber)
                    .HasColumnName("jobnumber")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeftNode)
                    .HasColumnName("leftNode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rightnode)
                    .HasColumnName("rightnode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Structurelevel)
                    .HasColumnName("structurelevel")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Manu>(entity =>
            {
                entity.Property(e => e.ManuId).HasColumnName("ManuID");

                entity.Property(e => e.ManuCategoryId)
                    .HasColumnName("ManuCategoryID")
                    .HasDefaultValueSql("((0))");

              
            });

            modelBuilder.Entity<Nfrc>(entity =>
            {
                entity.HasKey(e => e.CpdId);

                entity.ToTable("NFRC");

                entity.Property(e => e.CpdId).HasColumnName("CPD_ID");

                entity.Property(e => e.Cpd)
                    .HasColumnName("CPD")
                    .HasMaxLength(255);

                entity.Property(e => e.FrameMaterial)
                    .HasMaxLength(65)
                    .IsFixedLength();

                entity.Property(e => e.FrameSashType).HasMaxLength(255);

                entity.Property(e => e.GapFill).HasMaxLength(255);

                entity.Property(e => e.GlassId).HasColumnName("GlassID");

                entity.Property(e => e.GlassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grid).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Igu)
                    .HasColumnName("IGU")
                    .HasMaxLength(75)
                    .IsFixedLength();

                entity.Property(e => e.LowE).HasMaxLength(255);

                entity.Property(e => e.ManufacturerProductCode).HasMaxLength(255);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Shgc).HasColumnName("SHGC");

                entity.Property(e => e.Spacer).HasMaxLength(255);

                entity.Property(e => e.SystemId).HasColumnName("SystemID");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Tbreak).HasColumnName("TBreak");

                entity.Property(e => e.Tint).HasMaxLength(255);

                entity.Property(e => e.UnitType)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Vt).HasColumnName("VT");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.NotifyId);

                entity.Property(e => e.NotifyId).HasColumnName("NotifyID");

                entity.Property(e => e.Notification1)
                    .HasColumnName("Notification")
                    .HasMaxLength(50);

                entity.HasOne(d => d.OrderNumNavigation)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.OrderNum)
                    .HasConstraintName("FK_Notification_PurchaseOrder");
            });

            modelBuilder.Entity<OrderReciept>(entity =>
            {
                entity.HasKey(e => e.OrderReceiptId)
                    .HasName("PK_Reciept");

                entity.Property(e => e.OrderReceiptId).HasColumnName("OrderReceiptID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ReceiptDate).HasColumnType("date");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.OrderStatusId)
                    .HasColumnName("OrderStatusID")
                    .ValueGeneratedNever();

              
            });

 

            modelBuilder.Entity<PartCategory>(entity =>
            {
                entity.Property(e => e.PartCategoryId).HasColumnName("PartCategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(70)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PartClass>(entity =>
            {
                entity.Property(e => e.PartClassId).HasColumnName("PartClassID");

                entity.Property(e => e.PartClass1)
                    .HasColumnName("PartClass")
                    .HasMaxLength(70)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PartType>(entity =>
            {
                entity.Property(e => e.PartTypeId).HasColumnName("PartTypeID");

                entity.Property(e => e.PartType1)
                    .HasColumnName("PartType")
                    .HasMaxLength(75)
                    .IsFixedLength();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PartType)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("FK_PartType_Category");
            });

            modelBuilder.Entity<PartTypes>(entity =>
            {
                entity.HasKey(e => e.PartTypeId);

                entity.Property(e => e.PartTypeId).HasColumnName("PartTypeID");

                entity.Property(e => e.PartTypeName)
                    .HasMaxLength(75)
                    .IsFixedLength();
            });

        
            modelBuilder.Entity<ProductionGroup>(entity =>
            {
                entity.Property(e => e.ProductionGroupId).HasColumnName("ProductionGroupID");

                entity.Property(e => e.Created)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsContracted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ProductionGroupName)
                    .HasMaxLength(120)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PurchaseLineItem>(entity =>
            {
                entity.HasKey(e => e.LineID);

                entity.Property(e => e.LineID).HasColumnName("LineID");

                entity.Property(e => e.AmountReceived)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Bcode)
                    .HasColumnName("BCode")
                    .HasMaxLength(50);

                entity.Property(e => e.BomId).HasColumnName("BomID");

                entity.Property(e => e.Description)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Extended)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Note).HasMaxLength(254);

                entity.Property(e => e.OrderReceiptId).HasColumnName("OrderReceiptID");

                entity.Property(e => e.PartID).HasColumnName("PartID");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");

                entity.Property(e => e.Qnty)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierPartName)
                    .HasMaxLength(120)
                    .IsFixedLength()
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Thick)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.UoP).HasMaxLength(60);

                entity.Property(e => e.UoPprice)
                    .HasColumnName("UoPPrice")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseLineItem)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PurchaseLineItem_PurchaseOrder");
            });



            modelBuilder.Entity<Purchasers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Purchasers");

                entity.Property(e => e.DisplayName).HasMaxLength(101);
            });

            modelBuilder.Entity<Recieving>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Recieving");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Jobname)
                    .HasColumnName("jobname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderReceiptId).HasColumnName("OrderReceiptID");

                entity.Property(e => e.ReceiptDate).HasColumnType("date");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sdapcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SDAPCD");

                entity.Property(e => e.BoilingPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MixRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartID).HasColumnName("PartID");

                entity.Property(e => e.SdapcdId).HasColumnName("SDAPCD_id");

                entity.Property(e => e.VocContent)
                    .HasColumnName("VOC_Content")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VocLimit)
                    .HasColumnName("VOC_Limit")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ShipBy>(entity =>
            {
                entity.HasKey(e => e.ShipId);

                entity.Property(e => e.ShipId).HasColumnName("ShipID");

                entity.Property(e => e.ShipByName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockBill>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);
            });

         

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasIndex(e => e.SupplierName)
                    .HasName("IX_Suppliers");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TaskCode);

                entity.Property(e => e.TaskCode).ValueGeneratedNever();

                entity.Property(e => e.ActualTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostCalculation)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.EstimatedTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarkUp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PartAttachmentId).HasColumnName("PartAttachmentID");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tfactor).HasColumnName("TFactor");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TransActionType>(entity =>
            {
                entity.HasKey(e => e.TransactionsTypeId);

                entity.Property(e => e.TransactionsTypeId).HasColumnName("TransactionsTypeID");

                entity.Property(e => e.TransactionTypeName).HasMaxLength(35);
            });

           

          

            modelBuilder.Entity<WorkCenter>(entity =>
            {
                entity.HasNoKey();

               
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WorkOrderDate).HasColumnType("date");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");
            });

            modelBuilder.Entity<WorkOrderRouting>(entity =>
            {
                entity.HasKey(e => e.WorkOrderId);

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ScheduledEndDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
