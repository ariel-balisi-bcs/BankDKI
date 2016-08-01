using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankDKI.Models;
using  BankDKI.DataLayer;
using WebGrease.Css.Extensions;

namespace BankDKI.Controllers
{
    public class FinancialStatementsController : Controller
    {
        //DKICreditRatingEntities _entities = new DKICreditRatingEntities();
        //
        // GET: /FinancialStatements/

        public ActionResult StandAlone()
        {
            //var financialStatementStandAloneModel = new FinancialStatementStandAloneModel();
            try
            {
                //Current Assets
                //var currentAssets = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 1);
                //financialStatementStandAloneModel.CurrentAssets = new List<FinancialStatementModel>();
                //foreach (var asset in currentAssets)
                //{
                //    financialStatementStandAloneModel.CurrentAssets.Add(new FinancialStatementModel()
                //                                                        {
                //                                                            Id = asset.DescriptionID,
                //                                                            Description = asset.DescriptionName,
                //                                                            Amount = asset.Value,
                //                                                            YearAuditedProjected = asset.Date
                //                                                        });
                //}
                ////Fixed Assets
                //var fixedAssets = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 2);
                //financialStatementStandAloneModel.FixedAssets = new List<FinancialStatementModel>();
                //foreach (var asset in fixedAssets)
                //{
                //    financialStatementStandAloneModel.FixedAssets.Add(new FinancialStatementModel()
                //                                                      {
                //                                                          Id = asset.DescriptionID,
                //                                                          Description = asset.DescriptionName,
                //                                                          Amount = asset.Value,
                //                                                          YearAuditedProjected = asset.Date
                //                                                      });
                //}
                ////None Current Assets
                //var nonCurrentAssets = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 3);
                //financialStatementStandAloneModel.NonCurrentAssets = new List<FinancialStatementModel>();
                //foreach (var asset in nonCurrentAssets)
                //{
                //    financialStatementStandAloneModel.NonCurrentAssets.Add(new FinancialStatementModel()
                //                                                           {
                //                                                               Id = asset.DescriptionID,
                //                                                               Description = asset.DescriptionName,
                //                                                               Amount = asset.Value,
                //                                                               YearAuditedProjected = asset.Date
                //                                                           });
                //}
                ////Current Liabilities
                //var currentLiabilities = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 4);
                //financialStatementStandAloneModel.CurrentLiabilities = new List<FinancialStatementModel>();
                //foreach (var asset in currentLiabilities)
                //{
                //    financialStatementStandAloneModel.CurrentLiabilities.Add(new FinancialStatementModel()
                //                                                             {
                //                                                                 Id = asset.DescriptionID,
                //                                                                 Description = asset.DescriptionName,
                //                                                                 Amount = asset.Value,
                //                                                                 YearAuditedProjected = asset.Date
                //                                                             });
                //}

                ////None Current Liabilities
                //var nonCurrentLiabilities = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 5);
                //financialStatementStandAloneModel.NonCurrentLiabilities = new List<FinancialStatementModel>();
                //foreach (var asset in nonCurrentLiabilities)
                //{
                //    financialStatementStandAloneModel.NonCurrentLiabilities.Add(new FinancialStatementModel()
                //                                                                {
                //                                                                    Id = asset.DescriptionID,
                //                                                                    Description = asset.DescriptionName,
                //                                                                    Amount = asset.Value,
                //                                                                    YearAuditedProjected = asset.Date
                //                                                                });
                //}

                ////Equities
                //var equities = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 6);
                //financialStatementStandAloneModel.Equities = new List<FinancialStatementModel>();
                //foreach (var asset in equities)
                //{
                //    financialStatementStandAloneModel.Equities.Add(new FinancialStatementModel()
                //                                                   {
                //                                                       Id = asset.DescriptionID,
                //                                                       Description = asset.DescriptionName,
                //                                                       Amount = asset.Value,
                //                                                       YearAuditedProjected = asset.Date
                //                                                   });
                //}

                ////Gross profit
                //var grossProfit = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 7);
                //financialStatementStandAloneModel.GrossProfit = new List<FinancialStatementModel>();
                //foreach (var asset in grossProfit)
                //{
                //    financialStatementStandAloneModel.GrossProfit.Add(new FinancialStatementModel()
                //                                                      {
                //                                                          Id = asset.DescriptionID,
                //                                                          Description = asset.DescriptionName,
                //                                                          Amount = asset.Value,
                //                                                          YearAuditedProjected = asset.Date
                //                                                      });
                //}

                ////Net operating profit
                //var netOperatingProfit = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 8);
                //financialStatementStandAloneModel.NetOperatingProfit = new List<FinancialStatementModel>();
                //foreach (var asset in netOperatingProfit)
                //{
                //    financialStatementStandAloneModel.NetOperatingProfit.Add(new FinancialStatementModel()
                //                                                             {
                //                                                                 Id = asset.DescriptionID,
                //                                                                 Description = asset.DescriptionName,
                //                                                                 Amount = asset.Value,
                //                                                                 YearAuditedProjected = asset.Date
                //                                                             });
                //}

                ////Profit loss before income tax
                //var profitLoss = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 9);
                //financialStatementStandAloneModel.ProfitBeforeIncomeTax = new List<FinancialStatementModel>();
                //foreach (var asset in profitLoss)
                //{
                //    financialStatementStandAloneModel.ProfitBeforeIncomeTax.Add(new FinancialStatementModel()
                //                                                                {
                //                                                                    Id = asset.DescriptionID,
                //                                                                    Description = asset.DescriptionName,
                //                                                                    Amount = asset.Value,
                //                                                                    YearAuditedProjected = asset.Date
                //                                                                });
                //}

                ////Income for the period
                //var incomeForPeriod = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 10);
                //financialStatementStandAloneModel.IncomeTaxForPeriod = new List<FinancialStatementModel>();
                //foreach (var asset in incomeForPeriod)
                //{
                //    financialStatementStandAloneModel.IncomeTaxForPeriod.Add(new FinancialStatementModel()
                //                                                             {
                //                                                                 Id = asset.DescriptionID,
                //                                                                 Description = asset.DescriptionName,
                //                                                                 Amount = asset.Value,
                //                                                                 YearAuditedProjected = asset.Date
                //                                                             });
                //}

                ////Total comprehensive income
                //var totalComprehensive = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 11);
                //financialStatementStandAloneModel.TotalComprehensiveIncome = new List<FinancialStatementModel>();
                //foreach (var asset in totalComprehensive)
                //{
                //    financialStatementStandAloneModel.TotalComprehensiveIncome.Add(new FinancialStatementModel()
                //                                                                   {
                //                                                                       Id = asset.DescriptionID,
                //                                                                       Description =
                //                                                                           asset.DescriptionName,
                //                                                                       Amount = asset.Value,
                //                                                                       YearAuditedProjected = asset.Date
                //                                                                   });
                //}

                ////Equity increase
                //var equityIncrease = _entities.vwAuditedFS_SA_Summation.Where(x => x.GroupId == 12);
                //financialStatementStandAloneModel.EquityIncrease = new List<FinancialStatementModel>();
                //foreach (var asset in equityIncrease)
                //{
                //    financialStatementStandAloneModel.EquityIncrease.Add(new FinancialStatementModel()
                //                                                         {
                //                                                             Id = asset.DescriptionID,
                //                                                             Description = asset.DescriptionName,
                //                                                             Amount = asset.Value,
                //                                                             YearAuditedProjected = asset.Date
                //                                                         });
                //}

                ////Total assets
                //financialStatementStandAloneModel.TotalAssets = new List<decimal>
                //                                                {
                //                                                    financialStatementStandAloneModel.CurrentAssets
                //                                                        .Where
                //                                                        (x => x.YearAuditedProjected.Year == 2013)
                //                                                        .Sum(x => x.Amount)
                //                                                    +
                //                                                    financialStatementStandAloneModel.FixedAssets.Where(
                //                                                        x => x.YearAuditedProjected.Year == 2013)
                //                                                        .Sum(x => x.Amount)
                //                                                    +
                //                                                    financialStatementStandAloneModel.NonCurrentAssets
                //                                                        .Where(x => x.YearAuditedProjected.Year == 2013)
                //                                                        .Sum(x => x.Amount),
                //                                                    financialStatementStandAloneModel.CurrentAssets
                //                                                        .Where
                //                                                        (x => x.YearAuditedProjected.Year == 2014)
                //                                                        .Sum(x => x.Amount)
                //                                                    +
                //                                                    financialStatementStandAloneModel.FixedAssets.Where(
                //                                                        x => x.YearAuditedProjected.Year == 2014)
                //                                                        .Sum(x => x.Amount)
                //                                                    +
                //                                                    financialStatementStandAloneModel.NonCurrentAssets
                //                                                        .Where(x => x.YearAuditedProjected.Year == 2014)
                //                                                        .Sum(x => x.Amount),
                //                                                    financialStatementStandAloneModel.CurrentAssets
                //                                                        .Where
                //                                                        (x => x.YearAuditedProjected.Year == 2015)
                //                                                        .Sum(x => x.Amount)
                //                                                    +
                //                                                    financialStatementStandAloneModel.FixedAssets.Where(
                //                                                        x => x.YearAuditedProjected.Year == 2015)
                //                                                        .Sum(x => x.Amount)
                //                                                    +
                //                                                    financialStatementStandAloneModel.NonCurrentAssets
                //                                                        .Where(x => x.YearAuditedProjected.Year == 2015)
                //                                                        .Sum(x => x.Amount)
                //                                                };

                //financialStatementStandAloneModel.TotalLiabilities = new List<decimal>
                //                                                     {
                //                                                         financialStatementStandAloneModel.CurrentLiabilities
                //                                                             .Where
                //                                                             (x => x.YearAuditedProjected.Year == 2013)
                //                                                             .Sum(x => x.Amount)
                //                                                         +
                //                                                         financialStatementStandAloneModel.NonCurrentLiabilities
                //                                                             .Where(
                //                                                                 x =>
                //                                                             x.YearAuditedProjected.Year == 2013)
                //                                                             .Sum(x => x.Amount),
                //                                                         financialStatementStandAloneModel.CurrentLiabilities
                //                                                             .Where
                //                                                             (x => x.YearAuditedProjected.Year == 2014)
                //                                                             .Sum(x => x.Amount)
                //                                                         +
                //                                                         financialStatementStandAloneModel.NonCurrentLiabilities
                //                                                             .Where(
                //                                                                 x =>
                //                                                             x.YearAuditedProjected.Year == 2014)
                //                                                             .Sum(x => x.Amount),
                //                                                         financialStatementStandAloneModel.CurrentLiabilities
                //                                                             .Where
                //                                                             (x => x.YearAuditedProjected.Year == 2015)
                //                                                             .Sum(x => x.Amount)
                //                                                         +
                //                                                         financialStatementStandAloneModel.NonCurrentLiabilities
                //                                                             .Where(
                //                                                                 x =>
                //                                                             x.YearAuditedProjected.Year == 2015)
                //                                                             .Sum(x => x.Amount)
                //                                                     };
            }
            catch (Exception)
            {
                //ignored
            }

            return View();
        }

        //
        // GET: /FinancialStatements/

        public ActionResult Combination()
        {
            return View();
        }

    }
}
