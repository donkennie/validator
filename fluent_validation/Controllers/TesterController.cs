using fluent_validation.Models;
using fluent_validation.Validator;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesterController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            TesterValidator validator = new TesterValidator();
            List<string> ValidationMessages = new List<string>();
            var tester = new Tester
            {
                FirstName = "",
                Email = "bla!"
            };
            var validationResult = validator.Validate(tester);
            var response = new ResponseModel();
            if (!validationResult.IsValid)
            {
                response.IsValid = false;
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    ValidationMessages.Add(failure.ErrorMessage);
                }
                response.ValidationMessages = ValidationMessages;
            }
            return Ok(response);
        }
    }
}
