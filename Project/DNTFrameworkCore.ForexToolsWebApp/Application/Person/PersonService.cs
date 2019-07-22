using AutoMapper;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.Application.Services;
using DNTFrameworkCore.EFCore.Application;
using DNTFrameworkCore.EFCore.Context;
using DNTFrameworkCore.Eventing;
using DNTFrameworkCore.ForexToolsWebApp.Application.Person.Models;
using DNTFrameworkCore.ForexToolsWebApp.Domain.Person;
using DNTFrameworkCore.Functional;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Application.Person
{
    public interface IPersonService : ICrudService<int, PersonModel>
    {
    }
    public class PersonService : CrudService<Domain.Person.Person, int, PersonModel>, IPersonService
    {
        private readonly ILogger<PersonService> _logger;
        private readonly IMapper _mapper;

        public PersonService(IUnitOfWork uow, IEventBus bus, IMapper mapper, ILogger<PersonService> logger) : base(uow, bus)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override IQueryable<PersonModel> BuildReadQuery(FilteredPagedQueryModel model)
        {
            return EntitySet.AsNoTracking()
                .Select(b => new PersonModel
                {
                    Id = b.Id,
                    RowVersion = b.RowVersion,
                    Name = b.Name,
                    Family = b.Family
                });
        }

        protected override void MapToEntity(PersonModel model, Domain.Person.Person entity)
        {
            _mapper.Map(model, entity);
        }

        protected override PersonModel MapToModel(Domain.Person.Person entity)
        {
            return _mapper.Map<PersonModel>(entity);
        }

        protected override Task AfterFindAsync(IReadOnlyList<PersonModel> models)
        {
            _logger.LogInformation(nameof(AfterFindAsync));

            return Task.CompletedTask;
        }

        protected override Task AfterMappingAsync(IReadOnlyList<PersonModel> models, IReadOnlyList<Domain.Person.Person> Persons)
        {
            _logger.LogInformation(nameof(AfterMappingAsync));

            return Task.CompletedTask;
        }

        protected override Task<Result> BeforeCreateAsync(IReadOnlyList<PersonModel> models)
        {
            _logger.LogInformation(nameof(BeforeCreateAsync));

            return Task.FromResult(Ok());
        }

        protected override Task<Result> AfterCreateAsync(IReadOnlyList<PersonModel> models)
        {
            _logger.LogInformation(nameof(AfterCreateAsync));

            return Task.FromResult(Ok());
        }

        protected override Task<Result> BeforeEditAsync(
            IReadOnlyList<ModifiedModel<PersonModel>> models, IReadOnlyList<Domain.Person.Person> Persons)
        {
            _logger.LogInformation(nameof(BeforeEditAsync));

            return Task.FromResult(Ok());
        }

        protected override Task<Result> AfterEditAsync(
            IReadOnlyList<ModifiedModel<PersonModel>> models, IReadOnlyList<Domain.Person.Person> Persons)
        {
            _logger.LogInformation(nameof(AfterEditAsync));

            return Task.FromResult(Ok());
        }

        protected override Task<Result> BeforeDeleteAsync(IReadOnlyList<PersonModel> models)
        {
            _logger.LogInformation(nameof(BeforeDeleteAsync));

            return Task.FromResult(Ok());
        }

        protected override Task<Result> AfterDeleteAsync(IReadOnlyList<PersonModel> models)
        {
            _logger.LogInformation(nameof(AfterDeleteAsync));

            return Task.FromResult(Ok());
        }

    }
}
