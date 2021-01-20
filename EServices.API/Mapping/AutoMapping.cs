using AutoMapper;

using Eservices.API.DTO;
using EServices.Core.Data;

namespace Eservices.Core.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ActionAssignedUsers, ActionAssignedUserDTO>().ReverseMap();
            CreateMap<ActionForms, ActionFormDTO>().ReverseMap();
            CreateMap<ActionTypes, ActionTypeDTO>().ReverseMap();
            CreateMap<Applications, ApplicationDTO>().ReverseMap();
            CreateMap<ApplicationStages, ApplicationStageDTO>().ReverseMap();
            CreateMap<ApplicationStageActions, ApplicationStageActionDTO>().ReverseMap();
            CreateMap<AttachmentConstraints, AttachmentConstraintDTO>().ReverseMap();
            CreateMap<Entities, EntityDTO>().ReverseMap();
            CreateMap<Entities, OnlyEntityDTO>().ReverseMap().ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
            .ForAllOtherMembers(opts => opts.Ignore());
            CreateMap<EntityFields, EntityFieldDTO>().ReverseMap();
            CreateMap<EntityRelationships, EntityRelationshipDTO>().ReverseMap();
            CreateMap<Forms, FormDTO>().ReverseMap();
            CreateMap<FormFieldConstraints, FormFieldConstraintDTO>().ReverseMap();
            CreateMap<FormSections, FormSectionDTO>().ReverseMap();
            CreateMap<FormSectionAttachments, FormSectionAttachmentDTO>().ReverseMap();
            CreateMap<FormSectionFields, FormSectionFieldDTO>().ReverseMap();
            CreateMap<Groups, GroupDTO>().ReverseMap();
            CreateMap<Groups, OnlyGroupDTO>().ReverseMap().ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.ParentId, o => o.MapFrom(s => s.ParentId))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.OrderNumber, o => o.MapFrom(s => s.OrderNumber))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Description))
                .ForAllOtherMembers(opts => opts.Ignore());
            CreateMap<Languages, LanguageDTO>().ReverseMap();
            CreateMap<Roles, RoleDTO>().ReverseMap();
            CreateMap<EServices.Core.Data.Services, ServiceDTO>().ReverseMap();
            CreateMap<Stages, StageDTO>().ReverseMap();
            CreateMap<StageActions, StageActionDTO>().ReverseMap();
            CreateMap<StageActionRoles, StageActionRoleDTO>().ReverseMap();
            CreateMap<StageForms, StageFormDTO>().ReverseMap();
            CreateMap<Translations, TranslationDTO>().ReverseMap();
            CreateMap<TranslationKeys, TranslationKeyDTO>().ReverseMap();
            CreateMap<Users, UserDTO>().ReverseMap();
            
            CreateMap<Sections, SectionDTO>().ReverseMap();
            CreateMap<Categories, CategoryDTO>().ReverseMap();
            CreateMap<SubCategories, SubCategoryDTO>().ReverseMap();
            CreateMap<ProductTypes, ProductTypeDTO>().ReverseMap();
            CreateMap<NotifyBodies, NotifyBodyDTO>().ReverseMap();
            CreateMap<ThirdParties, ThirdPartyDTO>().ReverseMap();
            CreateMap<CategoryNotifyBodies, CategoryNotifyBodyDTO>().ReverseMap();
            CreateMap<SubCategoryProductTypes, SubCategoryProductTypeDTO>().ReverseMap();
            CreateMap<SubCategoryThirdParties, SubCategoryThirdPartyDTO>().ReverseMap();

            CreateMap<Countries, CountryDTO>().ReverseMap();
            CreateMap<Cities, CityDTO>().ReverseMap();


            CreateMap<FieldTypes, FieldTypeDTO>().ReverseMap();

            CreateMap<EntityFields, OnlyEntityFieldDTO>().ReverseMap().ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Settings, o => o.MapFrom(s => s.Settings))
                .ForMember(d => d.FieldTypeId, o => o.MapFrom(s => s.FieldTypeId))
                .ForMember(d => d.EntityId, o => o.MapFrom(s => s.EntityId))
                .ForAllOtherMembers(opts => opts.Ignore()); ;
            CreateMap<FiledLookups, FiledLookupDTO>().ReverseMap();

            CreateMap<EServices.Core.Data.Services, OnlyServiceDTO>().ReverseMap().ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.Settings, o => o.MapFrom(s => s.Settings))
                .ForMember(d => d.OrderNumber, o => o.MapFrom(s => s.OrderNumber))
                .ForMember(d => d.GroupId, o => o.MapFrom(s => s.GroupId))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Description))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<Stages, OnlyStagesDTO>().ReverseMap()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.OrderNumber, o => o.MapFrom(s => s.OrderNumber))
                .ForMember(d => d.ServiceId, o => o.MapFrom(s => s.ServiceId))
                .ForAllOtherMembers(opts => opts.Ignore());

            CreateMap<StageActions, OnlyStageActionDTO>().ReverseMap()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ForMember(d => d.OrderNumber, o => o.MapFrom(s => s.OrderNumber))
                .ForMember(d => d.StageId, o => o.MapFrom(s => s.StageId))
                .ForMember(d => d.ActionTypeId, o => o.MapFrom(s => s.ActionTypeId))
                .ForAllOtherMembers(opts => opts.Ignore());

        }
    }
}
