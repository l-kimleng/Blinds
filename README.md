# Blinds
You realize that your living room has too much sun light coming in. You are searching for room darkening blinds and so you visit www.Blinds.com (No 1 online retailer for Blinds). You are looking for the cheapest room darkening blinds available on the site so you sort the results from 'Low to High'. 

# Tools
1. Using Visual Studio 2017
2. Resharper (Nunit Test Runner)

# How to Build
1. Build project
2. Open Package Manager Console:
   -> Select Default project: Blinds
   -> Type: Update-Database
   
3. Run run project

# Deploy web api
  url: http://blinds-cc.azurewebsites.net/api/products?Name&BrandId=-1&IsSortAscending=false&Page=1&PageSize=10
