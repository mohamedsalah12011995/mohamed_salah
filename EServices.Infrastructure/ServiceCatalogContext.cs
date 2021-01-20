using EServices.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EServices.Infrastructure
{
    public partial class ServiceCatalogContext : DbContext
    {
        public ServiceCatalogContext()
        {
        }

        public ServiceCatalogContext(DbContextOptions<ServiceCatalogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionAssignedUsers> ActionAssignedUsers { get; set; }
        public virtual DbSet<ActionForms> ActionForms { get; set; }
        public virtual DbSet<ActionTypes> ActionTypes { get; set; }
        public virtual DbSet<ApplicationStageActions> ApplicationStageActions { get; set; }
        public virtual DbSet<ApplicationStages> ApplicationStages { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<AttachmentConstraintTypes> AttachmentConstraintTypes { get; set; }
        public virtual DbSet<AttachmentConstraints> AttachmentConstraints { get; set; }
        public virtual DbSet<AttachmentTypes> AttachmentTypes { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoryNotifyBodies> CategoryNotifyBodies { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<DeviceTypes> DeviceTypes { get; set; }
        public virtual DbSet<Entities> Entities { get; set; }
        public virtual DbSet<EntityFields> EntityFields { get; set; }
        public virtual DbSet<EntityRelationTypes> EntityRelationTypes { get; set; }
        public virtual DbSet<EntityRelationships> EntityRelationships { get; set; }
        public virtual DbSet<FieldConstraintTypes> FieldConstraintTypes { get; set; }
        public virtual DbSet<FieldTypeConstraintType> FieldTypeConstraintType { get; set; }
        public virtual DbSet<FieldTypes> FieldTypes { get; set; }
        public virtual DbSet<FormFieldConstraints> FormFieldConstraints { get; set; }
        public virtual DbSet<FormSectionAttachments> FormSectionAttachments { get; set; }
        public virtual DbSet<FormSectionFields> FormSectionFields { get; set; }
        public virtual DbSet<FormSections> FormSections { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<NotifyBodies> NotifyBodies { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<EServices.Core.Data.Services> Services { get; set; }
        public virtual DbSet<StageActionRoles> StageActionRoles { get; set; }
        public virtual DbSet<StageActions> StageActions { get; set; }
        public virtual DbSet<StageForms> StageForms { get; set; }
        public virtual DbSet<StageStatuses> StageStatuses { get; set; }
        public virtual DbSet<Stages> Stages { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<SubCategoryProductTypes> SubCategoryProductTypes { get; set; }
        public virtual DbSet<SubCategoryThirdParties> SubCategoryThirdParties { get; set; }
        public virtual DbSet<ThirdParties> ThirdParties { get; set; }
        public virtual DbSet<TranslationKeys> TranslationKeys { get; set; }
        public virtual DbSet<Translations> Translations { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionAssignedUsers>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationStageActionId, e.UserId });

                entity.ToTable("ActionAssignedUsers", "application");

                entity.HasOne(d => d.ApplicationStageAction)
                    .WithMany(p => p.ActionAssignedUsers)
                    .HasForeignKey(d => d.ApplicationStageActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionAssignedUsers_ApplicationStageActions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActionAssignedUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionAssignedUsers_Users");
            });

            modelBuilder.Entity<ActionForms>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.FormId });

                entity.ToTable("ActionForms", "service");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionForms)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionForms_ActionTypes");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.ActionForms)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionForms_Forms");
            });

            modelBuilder.Entity<ActionTypes>(entity =>
            {
                entity.ToTable("ActionTypes", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ApplicationStageActions>(entity =>
            {
                entity.ToTable("ApplicationStageActions", "application");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Data).HasColumnType("xml");

                entity.HasOne(d => d.ApplicationStage)
                    .WithMany(p => p.ApplicationStageActions)
                    .HasForeignKey(d => d.ApplicationStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStageActions_ApplicationStages");

                entity.HasOne(d => d.StageAction)
                    .WithMany(p => p.ApplicationStageActions)
                    .HasForeignKey(d => d.StageActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStageActions_StageActions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApplicationStageActions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStageActions_Users");
            });

            modelBuilder.Entity<ApplicationStages>(entity =>
            {
                entity.ToTable("ApplicationStages", "application");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationStages)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStages_Applications");

                entity.HasOne(d => d.PreviousStage)
                    .WithMany(p => p.InversePreviousStage)
                    .HasForeignKey(d => d.PreviousStageId)
                    .HasConstraintName("FK_ApplicationStages_ApplicationStages");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.ApplicationStages)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStages_Stages");

                entity.HasOne(d => d.StageStatus)
                    .WithMany(p => p.ApplicationStages)
                    .HasForeignKey(d => d.StageStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStages_StageStatuses");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApplicationStages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationStages_Users");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.ToTable("Applications", "application");

                entity.Property(e => e.ApplicationNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClientIpaddress)
                    .IsRequired()
                    .HasColumnName("ClientIPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Applications_Users");

                entity.HasOne(d => d.DeviceType)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.DeviceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Applications_DeviceTypes");

                entity.HasOne(d => d.ParentApplication)
                    .WithMany(p => p.InverseParentApplication)
                    .HasForeignKey(d => d.ParentApplicationId)
                    .HasConstraintName("FK_Applications_Applications");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Applications_Services");
            });

            modelBuilder.Entity<AttachmentConstraintTypes>(entity =>
            {
                entity.ToTable("AttachmentConstraintTypes", "service");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AttachmentConstraints>(entity =>
            {
                entity.HasKey(e => new { e.FormSectionAttachmentId, e.AttachmentConstraintTypeId })
                    .HasName("PK_AttachmentAttachmentConstraints");

                entity.ToTable("AttachmentConstraints", "service");

                entity.Property(e => e.Settings).HasColumnType("xml");

                entity.HasOne(d => d.AttachmentConstraintType)
                    .WithMany(p => p.AttachmentConstraints)
                    .HasForeignKey(d => d.AttachmentConstraintTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachmentConstraints_AttachmentConstraintTypes");

                entity.HasOne(d => d.FormSectionAttachment)
                    .WithMany(p => p.AttachmentConstraints)
                    .HasForeignKey(d => d.FormSectionAttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachmentConstraints_Attachments");
            });

            modelBuilder.Entity<AttachmentTypes>(entity =>
            {
                entity.ToTable("AttachmentTypes", "service");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("Categories", "lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_Sections");
            });

            modelBuilder.Entity<CategoryNotifyBodies>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.NotifyBodyId })
                    .HasName("PK_SubCategoryNotifyBodies");

                entity.ToTable("CategoryNotifyBodies", "lookup");

                entity.Property(e => e.NotifyBodyCertificate).HasMaxLength(20);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryNotifyBodies)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryNotifyBodies_Categories");

                entity.HasOne(d => d.NotifyBody)
                    .WithMany(p => p.CategoryNotifyBodies)
                    .HasForeignKey(d => d.NotifyBodyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryNotifyBodies_NotifyBodies");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("Cities", "lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Cities_Countries");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("Countries", "lookup");

                entity.Property(e => e.Isocode2)
                    .IsRequired()
                    .HasColumnName("ISOCode2")
                    .HasMaxLength(2);

                entity.Property(e => e.Isocode3)
                    .IsRequired()
                    .HasColumnName("ISOCode3")
                    .HasMaxLength(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NumericCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PhoneCode)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<DeviceTypes>(entity =>
            {
                entity.ToTable("DeviceTypes", "application");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Entities>(entity =>
            {
                entity.ToTable("Entities", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EntityFields>(entity =>
            {
                entity.ToTable("EntityFields", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Settings).HasColumnType("xml");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityFields)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityFields_Entities");

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.EntityFields)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityFields_FieldTypes");
            });

            modelBuilder.Entity<EntityRelationTypes>(entity =>
            {
                entity.ToTable("EntityRelationTypes", "service");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EntityRelationships>(entity =>
            {
                entity.HasKey(e => new { e.FromEntityId, e.ToEntityId })
                    .HasName("PK_EntityRelationship");

                entity.ToTable("EntityRelationships", "service");

                entity.HasOne(d => d.EntityField)
                    .WithMany(p => p.EntityRelationships)
                    .HasForeignKey(d => d.EntityFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityRelationship_EntityFields");

                entity.HasOne(d => d.EntityRelationshipType)
                    .WithMany(p => p.EntityRelationships)
                    .HasForeignKey(d => d.EntityRelationshipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityRelationships_EntityRelationTypes");

                entity.HasOne(d => d.FromEntity)
                    .WithMany(p => p.EntityRelationshipsFromEntity)
                    .HasForeignKey(d => d.FromEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityRelationship_Entities");

                entity.HasOne(d => d.ToEntity)
                    .WithMany(p => p.EntityRelationshipsToEntity)
                    .HasForeignKey(d => d.ToEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityRelationship_Entities1");
            });

            modelBuilder.Entity<FieldConstraintTypes>(entity =>
            {
                entity.ToTable("FieldConstraintTypes", "service");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FieldTypeConstraintType>(entity =>
            {
                entity.HasKey(e => new { e.FieldConstraintTypeId, e.FieldTypeId });

                entity.ToTable("FieldTypeConstraintType", "service");

                entity.HasOne(d => d.FieldConstraintType)
                    .WithMany(p => p.FieldTypeConstraintType)
                    .HasForeignKey(d => d.FieldConstraintTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldTypeConstraintType_FieldConstraintTypes");

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.FieldTypeConstraintType)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldTypeConstraintType_FieldTypes");
            });

            modelBuilder.Entity<FieldTypes>(entity =>
            {
                entity.ToTable("FieldTypes", "service");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FormFieldConstraints>(entity =>
            {
                entity.ToTable("FormFieldConstraints", "service");

                entity.Property(e => e.Settings).HasColumnType("xml");

                entity.HasOne(d => d.FieldConstraintType)
                    .WithMany(p => p.FormFieldConstraints)
                    .HasForeignKey(d => d.FieldConstraintTypeId)
                    .HasConstraintName("FK_FormFieldConstraints_FieldConstraintTypes");

                entity.HasOne(d => d.FormSectionField)
                    .WithMany(p => p.FormFieldConstraints)
                    .HasForeignKey(d => d.FormSectionFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormFieldConstraints_FormFields");
            });

            modelBuilder.Entity<FormSectionAttachments>(entity =>
            {
                entity.ToTable("FormSectionAttachments", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.FormSectionAttachments)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attachments_AttachmentTypes");

                entity.HasOne(d => d.FormSection)
                    .WithMany(p => p.FormSectionAttachments)
                    .HasForeignKey(d => d.FormSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attachments_Forms");
            });

            modelBuilder.Entity<FormSectionFields>(entity =>
            {
                entity.ToTable("FormSectionFields", "service");

                entity.HasOne(d => d.EntityField)
                    .WithMany(p => p.FormSectionFields)
                    .HasForeignKey(d => d.EntityFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormSectionFields_EntityFields");

                entity.HasOne(d => d.FormSection)
                    .WithMany(p => p.FormSectionFields)
                    .HasForeignKey(d => d.FormSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormFields_Forms");
            });

            modelBuilder.Entity<FormSections>(entity =>
            {
                entity.ToTable("FormSections", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Settings).HasColumnType("xml");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormSections)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FormSections_Forms");
            });

            modelBuilder.Entity<Forms>(entity =>
            {
                entity.ToTable("Forms", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Settings).HasColumnType("xml");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.ToTable("Groups", "service");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Groups_Groups");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.ToTable("Languages", "service");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NotifyBodies>(entity =>
            {
                entity.ToTable("NotifyBodies", "lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductTypes>(entity =>
            {
                entity.ToTable("ProductTypes", "lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(270);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("Roles", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.ToTable("Sections", "lookup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EServices.Core.Data.Services>(entity =>
            {
                entity.ToTable("Services", "service");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Settings).HasColumnType("xml");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Groups");
            });

            modelBuilder.Entity<StageActionRoles>(entity =>
            {
                entity.HasKey(e => new { e.StageActionId, e.RoleId });

                entity.ToTable("StageActionRoles", "service");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StageActionRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StageActionRoles_Roles");

                entity.HasOne(d => d.StageAction)
                    .WithMany(p => p.StageActionRoles)
                    .HasForeignKey(d => d.StageActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StageActionRoles_StageActions");
            });

            modelBuilder.Entity<StageActions>(entity =>
            {
                entity.ToTable("StageActions", "service");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.ActionType)
                    .WithMany(p => p.StageActions)
                    .HasForeignKey(d => d.ActionTypeId)
                    .HasConstraintName("FK_StageActions_ActionType");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.StageActions)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceActions_Stages");
            });

            modelBuilder.Entity<StageForms>(entity =>
            {
                entity.HasKey(e => new { e.StageId, e.FormId });

                entity.ToTable("StageForms", "service");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.StageForms)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StageForms_Forms");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.StageForms)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StageForms_Stages");
            });

            modelBuilder.Entity<StageStatuses>(entity =>
            {
                entity.ToTable("StageStatuses", "application");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Stages>(entity =>
            {
                entity.ToTable("Stages", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Stages)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stages_Services");
            });

            modelBuilder.Entity<SubCategories>(entity =>
            {
                entity.ToTable("SubCategories", "lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_SubCategories_Categories");
            });

            modelBuilder.Entity<SubCategoryProductTypes>(entity =>
            {
                entity.HasKey(e => new { e.SubCategoryId, e.ProductTypeId });

                entity.ToTable("SubCategoryProductTypes", "lookup");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.SubCategoryProductTypes)
                    .HasForeignKey(d => d.ProductTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategoryProductTypes_ProductTypes");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.SubCategoryProductTypes)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategoryProductTypes_SubCategories");
            });

            modelBuilder.Entity<SubCategoryThirdParties>(entity =>
            {
                entity.HasKey(e => new { e.ThirdPartyId, e.SubCategoryId });

                entity.ToTable("SubCategoryThirdParties", "lookup");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.SubCategoryThirdParties)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategoryThirdParties_SubCategories");

                entity.HasOne(d => d.ThirdParty)
                    .WithMany(p => p.SubCategoryThirdParties)
                    .HasForeignKey(d => d.ThirdPartyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategoryThirdParties_ThirdParties");
            });

            modelBuilder.Entity<ThirdParties>(entity =>
            {
                entity.ToTable("ThirdParties", "lookup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TranslationKeys>(entity =>
            {
                entity.ToTable("TranslationKeys", "service");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Translations>(entity =>
            {
                entity.HasKey(e => new { e.TranslationKeyId, e.LanguageId, e.ItemId });

                entity.ToTable("Translations", "service");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Translations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Translations_Languages");

                entity.HasOne(d => d.TranslationKey)
                    .WithMany(p => p.Translations)
                    .HasForeignKey(d => d.TranslationKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Translations_TranslationKeys");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "service");

                entity.Property(e => e.ExternalId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
