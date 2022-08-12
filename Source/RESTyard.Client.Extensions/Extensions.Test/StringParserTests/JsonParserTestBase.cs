﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Test.StringParserTests
{
    public class JsonParserTestBase : StringParserTestBase
    {
        [TestInitialize]
        public virtual void Initialize()
        {
            TextToBeParsed =
                "{\r\n  \"class\": [\r\n    \"CustomersQueryResult\"\r\n  ],\r\n  \"title\": \"Query result on Customers\",\r\n  \"properties\": {\r\n    \"TotalEnties\": 20,\r\n    \"CurrentEntitiesCount\": 3\r\n  },\r\n  \"entities\": [\r\n    {\r\n      \"class\": [\r\n        \"Customer\"\r\n      ],\r\n      \"title\": \"A Customer\",\r\n      \"rel\": [\r\n        \"item\"\r\n      ],\r\n      \"properties\": {\r\n        \"FullName\": \"Adam Wong\",\r\n        \"Age\": 31,\r\n        \"Address\": \"Lantern Lane 202 Saint Petersburg\",\r\n        \"IsFavorite\": false\r\n      },\r\n      \"entities\": [],\r\n      \"actions\": [\r\n        {\r\n          \"name\": \"CustomerMove\",\r\n          \"title\": \"A Customer moved to a new location.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/10/Moves\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"NewAddress\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/Customers/NewAddressType\"\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"name\": \"MarkAsFavoriteAction\",\r\n          \"title\": \"Marks a Customer as a favorite buyer.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/MyFavoriteCustomers?key=10\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"FavoriteCustomer\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/ActionParameterTypes/FavoriteCustomer\"\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"name\": \"BuyCarAction\",\r\n          \"title\": \"Buy a car.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/10/BuysCar\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"HypermediaActionCustomerBuysCar.Parameter\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/ActionParameterTypes/HypermediaActionCustomerBuysCar.Parameter\"\r\n              ]\r\n            }\r\n          ]\r\n        }\r\n      ],\r\n      \"links\": [\r\n        {\r\n          \"rel\": [\r\n            \"self\"\r\n          ],\r\n          \"href\": \"http://localhost:5000/Customers/10\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"class\": [\r\n        \"Customer\"\r\n      ],\r\n      \"title\": \"A Customer\",\r\n      \"rel\": [\r\n        \"item\"\r\n      ],\r\n      \"properties\": {\r\n        \"FullName\": \"Duncan Miranda\",\r\n        \"Age\": 40,\r\n        \"Address\": \"Cambridge Road 11 Riyadh\",\r\n        \"IsFavorite\": true\r\n      },\r\n      \"entities\": [],\r\n      \"actions\": [\r\n        {\r\n          \"name\": \"CustomerMove\",\r\n          \"title\": \"A Customer moved to a new location.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/13/Moves\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"NewAddress\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/Customers/NewAddressType\"\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"name\": \"BuyCarAction\",\r\n          \"title\": \"Buy a car.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/13/BuysCar\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"HypermediaActionCustomerBuysCar.Parameter\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/ActionParameterTypes/HypermediaActionCustomerBuysCar.Parameter\"\r\n              ]\r\n            }\r\n          ]\r\n        }\r\n      ],\r\n      \"links\": [\r\n        {\r\n          \"rel\": [\r\n            \"self\"\r\n          ],\r\n          \"href\": \"http://localhost:5000/Customers/13\"\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"class\": [\r\n        \"Customer\"\r\n      ],\r\n      \"title\": \"A Customer\",\r\n      \"rel\": [\r\n        \"item\"\r\n      ],\r\n      \"properties\": {\r\n        \"FullName\": \"Christine Kelly\",\r\n        \"Age\": 41,\r\n        \"Address\": \"Eagle Street 62 Cairo\",\r\n        \"IsFavorite\": false\r\n      },\r\n      \"entities\": [],\r\n      \"actions\": [\r\n        {\r\n          \"name\": \"CustomerMove\",\r\n          \"title\": \"A Customer moved to a new location.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/6/Moves\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"NewAddress\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/Customers/NewAddressType\"\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"name\": \"MarkAsFavoriteAction\",\r\n          \"title\": \"Marks a Customer as a favorite buyer.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/MyFavoriteCustomers?key=6\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"FavoriteCustomer\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/ActionParameterTypes/FavoriteCustomer\"\r\n              ]\r\n            }\r\n          ]\r\n        },\r\n        {\r\n          \"name\": \"BuyCarAction\",\r\n          \"title\": \"Buy a car.\",\r\n          \"method\": \"POST\",\r\n          \"href\": \"http://localhost:5000/Customers/6/BuysCar\",\r\n          \"type\": \"application/json\",\r\n          \"fields\": [\r\n            {\r\n              \"name\": \"HypermediaActionCustomerBuysCar.Parameter\",\r\n              \"type\": \"application/json\",\r\n              \"class\": [\r\n                \"http://localhost:5000/ActionParameterTypes/HypermediaActionCustomerBuysCar.Parameter\"\r\n              ]\r\n            }\r\n          ]\r\n        }\r\n      ],\r\n      \"links\": [\r\n        {\r\n          \"rel\": [\r\n            \"self\"\r\n          ],\r\n          \"href\": \"http://localhost:5000/Customers/6\"\r\n        }\r\n      ]\r\n    }\r\n  ],\r\n  \"actions\": [],\r\n  \"links\": [\r\n    {\r\n      \"rel\": [\r\n        \"self\"\r\n      ],\r\n      \"href\": \"http://localhost:5000/Customers/Query?Pagination.PageSize=3&Pagination.PageOffset=2&SortBy.PropertyName=Age&SortBy.SortType=Ascending&Filter.MinAge=22\"\r\n    },\r\n    {\r\n      \"rel\": [\r\n        \"all\"\r\n      ],\r\n      \"href\": \"http://localhost:5000/Customers/Query?SortBy.PropertyName=Age&SortBy.SortType=Ascending&Filter.MinAge=22\"\r\n    },\r\n    {\r\n      \"rel\": [\r\n        \"first\"\r\n      ],\r\n      \"href\": \"http://localhost:5000/Customers/Query?Pagination.PageSize=3&SortBy.PropertyName=Age&SortBy.SortType=Ascending&Filter.MinAge=22\"\r\n    },\r\n    {\r\n      \"rel\": [\r\n        \"next\"\r\n      ],\r\n      \"href\": \"http://localhost:5000/Customers/Query?Pagination.PageSize=3&Pagination.PageOffset=5&SortBy.PropertyName=Age&SortBy.SortType=Ascending&Filter.MinAge=22\"\r\n    },\r\n    {\r\n      \"rel\": [\r\n        \"previous\"\r\n      ],\r\n      \"href\": \"http://localhost:5000/Customers/Query?Pagination.PageSize=3&SortBy.PropertyName=Age&SortBy.SortType=Ascending&Filter.MinAge=22\"\r\n    },\r\n    {\r\n      \"rel\": [\r\n        \"last\"\r\n      ],\r\n      \"href\": \"http://localhost:5000/Customers/Query?Pagination.PageSize=3&Pagination.PageOffset=17&SortBy.PropertyName=Age&SortBy.SortType=Ascending&Filter.MinAge=22\"\r\n    }\r\n  ]\r\n}";
        }
    }
}