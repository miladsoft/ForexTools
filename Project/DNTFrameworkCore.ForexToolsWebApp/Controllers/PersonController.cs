using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNTFrameworkCore.ForexToolsWebApp.Application.Person;
using DNTFrameworkCore.ForexToolsWebApp.Application.Person.Models;
using DNTFrameworkCore.ForexToolsWebApp.Authorization;
using DNTFrameworkCore.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DNTFrameworkCore.ForexToolsWebApp.Controllers
{
    public class PersonController : CrudController<IPersonService, int, PersonModel>
    {
        public PersonController(IPersonService service) : base(service)
        {
        }
        protected override string CreatePermissionName => PermissionNames.Person_Create;
        protected override string EditPermissionName => PermissionNames.Person_Edit;
        protected override string ViewPermissionName => PermissionNames.Person_View;
        protected override string DeletePermissionName => PermissionNames.Person_Delete;
        protected override string ViewName => "_PersonModal";


    }
}