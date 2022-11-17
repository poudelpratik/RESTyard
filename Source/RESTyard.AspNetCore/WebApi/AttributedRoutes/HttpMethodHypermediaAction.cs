using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Routing;
using RESTyard.AspNetCore.Hypermedia.Actions;

namespace RESTyard.AspNetCore.WebApi.AttributedRoutes
{
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class HttpMethodHypermediaAction : HttpMethodAttribute, IHaveRouteInfo
    {
        /// <summary>
        ///     Indicates that this route will accept requests with a supported method generated by the corresponding
        ///     HypermediaAction used in HypermediaObjects.
        ///     Each action in a Object must be matched by a route. No other route my have the same type. A action route must be
        ///     always a subroute of an HypermediaObject.
        /// </summary>
        /// <param name="httpMethods">The set of supported methods. May not be null.</param>
        /// <param name="routeType">type of the HypermediaAction as used in the HypermediaObject</param>
        /// <param name="routeKeyProducerType">
        ///     If the route template contains a (single) key it is required that the type of the responsible RouteKeyProducer is
        ///     given.
        ///     This type will be used to create a n instance of the producer and generate the key object used in a UrlHelper to
        ///     determine the final URL.
        /// </param>
        public HttpMethodHypermediaAction(
            IEnumerable<string> httpMethods,
            Type routeType,
            Type routeKeyProducerType = null) : base(httpMethods)
        {
            Init(routeType, routeKeyProducerType);
        }

        /// <summary>
        ///     Indicates that this route will accept requests with a supported method generated by the corresponding
        ///     HypermediaAction used in HypermediaObjects.
        ///     Each action in a Object must be matched by a route. No other route my have the same type. A action route must be
        ///     always a subroute of an HypermediaObject.
        /// </summary>
        /// <param name="httpMethods">The set of supported methods. May not be null.</param>
        /// <param name="template">The route template.</param>
        /// <param name="routeType">type of the HypermediaAction as used in the HypermediaObject</param>
        /// <param name="routeKeyProducerType">
        ///     If the route template contains a (single) key it is required that the type of the responsible RouteKeyProducer is
        ///     given.
        ///     This type will be used to create a n instance of the producer and generate the key object used in a UrlHelper to
        ///     determine the final URL.
        /// </param>
        public HttpMethodHypermediaAction(
            IEnumerable<string> httpMethods,
            string template,
            Type routeType,
            Type routeKeyProducerType = null) : base(httpMethods, template)
        {
            Init(routeType, routeKeyProducerType);
        }

        public Type RouteType { get; private set; }
        public Type RouteKeyProducerType { get; private set; }
        
        
        /// <summary>
        /// The media type which is acceptable for this action. 
        /// </summary>
        public string AcceptedMediaType { get; set; } = null;

        private void Init(Type routeType, Type routeKeyProducerType)
        {
            AttributedRouteHelper.EnsureIs<HypermediaActionBase>(routeType);
            AttributedRouteHelper.EnsureIsRouteKeyProducer(routeKeyProducerType);

            var buildName = "GenericRouteName_HypermediaAction" + "_" + routeType;
            buildName = AttributedRouteHelper.EscapeRouteName(buildName);

            Name = buildName;
            RouteType = routeType;
            RouteKeyProducerType = routeKeyProducerType;
        }
    }
}