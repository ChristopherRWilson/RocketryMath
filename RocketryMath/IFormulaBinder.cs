using System;
using System.Web.Mvc;

namespace RocketryMath
{
    public class IFormulaBinder : DefaultModelBinder

    {
        /*
        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
        }
        */



        #region Public Methods

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var context = new ModelBindingContext(bindingContext);

            var item = Activator.CreateInstance(Type.GetType(controllerContext.RequestContext.HttpContext.Request.Params["AssemblyQualifiedName"]));

            Func<object> modelAccessor = () => item;
            context.ModelMetadata = new ModelMetadata(new DataAnnotationsModelMetadataProvider(), bindingContext.ModelMetadata.ContainerType, modelAccessor, item.GetType(), bindingContext.ModelName);

            return base.BindModel(controllerContext, context);
        }

        #endregion Public Methods
    }
}