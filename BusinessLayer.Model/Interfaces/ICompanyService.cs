﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Model.Models;

namespace BusinessLayer.Model.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyInfo>> GetAllCompaniesAsync();
        Task<CompanyInfo> GetCompanyByCodeAsync(string siteId, string companyCode);
        Task<bool> SaveCompanyAsync(CompanyInfo company);
        Task<bool> DeleteCompanyAsync(string siteId, string companyCode);
    }
}
