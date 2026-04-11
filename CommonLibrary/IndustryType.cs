using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonLibrary
{
    public enum  IndustryType
    {
        [Display(Name = "Food & Beverage")]
        [Description("Food and Beverage industry includes companies that produce, process, and distribute food and drink products.")]
        FoodAndBeverage,
        [Display(Name = "Agriculture")]
        [Description("Agriculture industry includes companies involved in the cultivation of plants and livestock.")]
        Agriculture,
        [Display(Name = "Technology")]
        [Description("Technology industry includes companies involved in the development and manufacturing of technology products or providing technology as a service.")]
        Technology,
        [Display(Name = "Defense")]
        [Description("Defense industry includes companies involved in the production of military equipment and services.")]
        Defense,
        [Display(Name = "Finance")]
        [Description("Finance industry includes companies involved in banking, investment, and other financial services.")]
        Finance,
        [Display(Name = "Manufacturing")]
        [Description("Manufacturing industry includes companies involved in the production of goods using labor, machines, tools, and chemical or biological processing.")]
        Manufacturing,
        [Display(Name = "Healthcare")]
        [Description("Healthcare industry includes companies involved in the provision of medical services, manufacturing of medical equipment or drugs, and insurance services.")]
        Healthcare,
        [Display(Name = "Media")]
        [Description("Media industry includes companies involved in the production and distribution of content through various channels such as television, radio, print, and digital platforms.")]
        Media,
        [Display(Name = "Retail")]
        [Description("Retail industry includes companies involved in the sale of goods and services directly to consumers.")]
        Retail,
        [Display(Name = "Education")]
        [Description("Education industry includes companies involved in the provision of educational services and products.")]
        Education,
        [Display(Name = "Energy")]
        [Description("Energy industry includes companies involved in the production and distribution of energy, including renewable and non-renewable sources.")]
        Energy,
        [Display(Name = "Fashion")]
        [Description("Fashion industry includes companies involved in the design, production, and marketing of clothing, accessories, and footwear.")]
        Fashion,
        [Display(Name = "Transportation")]
        [Description("Transportation industry includes companies involved in the movement of people and goods, including logistics and infrastructure.")]
        Transportation,
        [Display(Name = "Government")]
        [Description("Government industry includes organizations involved in the administration and regulation of public policies and services.")]
        Government,
        [Display(Name = "Non-Profit")]
        [Description("Non-Profit industry includes organizations that operate for charitable, educational, or social purposes rather than for profit.")]
        NonProfit,
        [Display(Name = "Hospitality")]
        [Description("Hospitality industry includes companies involved in providing lodging, food, and beverage services to travelers and tourists.")]
        Hospitality,
        [Display(Name = "Entertainment")]
        [Description("Entertainment industry includes companies involved in the production and distribution of content for various media platforms.")]
        Entertainment,
        [Display(Name = "Environment")]
        [Description("Environment industry includes companies involved in the protection and preservation of natural resources and ecosystems.")]
        Environment,
        [Display(Name = "Telecommunications")]
        [Description("Telecommunications industry includes companies involved in the transmission of information over various types of networks.")]
        Telecommunications,
        [Display(Name = "Aerospace")]       
        [Description("Aerospace industry includes companies involved in the design, development, and production of aircraft, spacecraft, and related systems and equipment.")]  
        Aerospace,
        [Display(Name = "Legal Services")]
        [Description("Legal Services industry includes companies involved in providing legal advice and representation to clients.")]
        LegalServices,
        [Display(Name = "Consulting")]
        [Description("Consulting industry includes companies involved in providing expert advice and services to organizations in various fields.")]    
        Consulting,
        [Display(Name = "Marketing")]
        [Description("Marketing industry includes companies involved in promoting and selling products or services, including market research and advertising.")]
        Marketing,
        [Display(Name = "Real Estate")]
        [Description("Real Estate industry includes companies involved in the buying, selling, and management of properties.")]
        RealEstate,
        [Display(Name = "Venture Capital")]
        [Description("Venture Capital industry includes companies involved in providing funding to startups and early-stage companies in exchange for equity.")]
        VentureCapital,
        [Display(Name = "Hospitality and Tourism")]
        [Description("Hospitality and Tourism industry includes companies involved in providing lodging, food, and beverage services to travelers and tourists, as well as related activities such as travel and tour services.")]
        HospitalityAndTourism,
        [Display(Name = "Sports and Recreation")]
        [Description("Sports and Recreation industry includes companies involved in the organization and promotion of sports events, as well as the provision of recreational activities and facilities.")]   
        SportsAndRecreation,
        [Display(Name = "Arts and Culture")]
        [Description("Arts and Culture industry includes companies involved in the creation, promotion, and preservation of artistic and cultural activities, events, and institutions.")]
        ArtsAndCulture,
        [Display(Name = "Travel and Tourism")]
        [Description("Travel and Tourism industry includes companies involved in providing travel and tour services, as well as related activities.")]
        TravelAndTourism,
        [Display(Name = "Recycling")]
        [Description("Recycling industry includes companies involved in the collection, processing, and reuse of materials.")]
        Recycling,
        [Display(Name = "Forestry")]
        [Description("Forestry industry includes companies involved in the management and conservation of forests, as well as the production of wood and related products.")]
        Forestry,
        [Display(Name = "Insurance")]
        [Description("Insurance industry includes companies involved in providing risk management and financial protection services.")]
        Insurance,
        [Display(Name = "Investment and Wealth Management")]
        [Description("Investment and Wealth Management industry includes companies involved in managing and investing financial assets.")]
        Investment,
        [Display(Name = "Mining, Quarrying, and Oil and Gas Extraction")]
        [Description("Mining, Quarrying, and Oil and Gas Extraction industry includes companies involved in the extraction of natural resources, including minerals, oil, and gas.")]
        MiningQuarrying,
        [Display(Name = "Construction")]
        [Description("Construction industry includes companies involved in the construction of buildings, infrastructure, and other structures.")]
        Construction,
        [Display(Name = "Warehousing")]
        [Description("Warehousing industry includes companies involved in the storage and distribution of goods.")]
        Warehousing,
        [Display(Name = "Repair, Maintenance, and Services")]
        [Description("Repair, Maintenance, and Services industry includes companies involved in providing repair, maintenance, and other services.")]
        RepairServiceMaintenance,
        [Display(Name = "Other")]
        [Description("Other industry includes companies that do not fit into the predefined categories.")]  
        Other,
        [Display(Name = "Unknown")]
        [Description("Unknown industry includes companies whose industry classification is not known.")]
        Unknown
    }
}