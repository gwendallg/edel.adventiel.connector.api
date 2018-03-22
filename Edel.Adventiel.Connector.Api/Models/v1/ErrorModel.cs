using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Edel.Adventiel.Connector.Api.Models.V1
{
    public class ErrorModel
    {
        public List<string> Messages { get; set; }

        public ErrorModel()
        {

        }

        public ErrorModel(ModelStateDictionary modelState)
        {
            Messages = new List<string>();
            if (modelState == null) throw new ArgumentNullException(nameof(modelState));
            foreach (var item in modelState.Values)
            foreach (var error in item.Errors)
                Messages.Add(error.ErrorMessage);
        }

        public ErrorModel(Exception exception)
        {
            if (exception == null) throw new ArgumentNullException(nameof(exception));
            Messages = new List<string>();
            Messages.Add(exception.Message);
        }
    }
}