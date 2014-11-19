using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TP.EntityFramework.Models.Mapping;

namespace TP.EntityFramework.Models
{
    public partial class TinkPrintContext : DbContext
    {
        static TinkPrintContext()
        {
            Database.SetInitializer<TinkPrintContext>(null);
        }

        public TinkPrintContext()
            : base("Name=TinkPrintContext")
        {
        }

        public DbSet<AUT_Role> AUT_Role { get; set; }
        public DbSet<AUT_RoleMenuFunction> AUT_RoleMenuFunction { get; set; }
        public DbSet<AUT_RoleModule> AUT_RoleModule { get; set; }
        public DbSet<AUT_RoleModuleMenu> AUT_RoleModuleMenu { get; set; }
        public DbSet<AUT_User> AUT_User { get; set; }
        public DbSet<AUT_UserRole> AUT_UserRole { get; set; }
        public DbSet<ORG_AuthorizeUserStore> ORG_AuthorizeUserStore { get; set; }
        public DbSet<ORG_Company> ORG_Company { get; set; }
        public DbSet<ORG_Department> ORG_Department { get; set; }
        public DbSet<ORG_Employee> ORG_Employee { get; set; }
        public DbSet<ORG_EmployeeDepartmentHistory> ORG_EmployeeDepartmentHistory { get; set; }
        public DbSet<ORG_Shift> ORG_Shift { get; set; }
        public DbSet<ORG_Store> ORG_Store { get; set; }
        public DbSet<SYS_Function> SYS_Function { get; set; }
        public DbSet<SYS_Menu> SYS_Menu { get; set; }
        public DbSet<SYS_MenuFunction> SYS_MenuFunction { get; set; }
        public DbSet<SYS_Module> SYS_Module { get; set; }
        public DbSet<SYS_OrderRemindSetting> SYS_OrderRemindSetting { get; set; }
        public DbSet<SYS_PrepaymentsSetting> SYS_PrepaymentsSetting { get; set; }
        public DbSet<SYS_SysSetting> SYS_SysSetting { get; set; }
        public DbSet<SYS_TaxRateCategory> SYS_TaxRateCategory { get; set; }
        public DbSet<SYS_Unit> SYS_Unit { get; set; }
        public DbSet<SYS_VoucherData> SYS_VoucherData { get; set; }
        public DbSet<SYS_VoucherEncodingRule> SYS_VoucherEncodingRule { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AUT_RoleMap());
            modelBuilder.Configurations.Add(new AUT_RoleMenuFunctionMap());
            modelBuilder.Configurations.Add(new AUT_RoleModuleMap());
            modelBuilder.Configurations.Add(new AUT_RoleModuleMenuMap());
            modelBuilder.Configurations.Add(new AUT_UserMap());
            modelBuilder.Configurations.Add(new AUT_UserRoleMap());
            modelBuilder.Configurations.Add(new ORG_AuthorizeUserStoreMap());
            modelBuilder.Configurations.Add(new ORG_CompanyMap());
            modelBuilder.Configurations.Add(new ORG_DepartmentMap());
            modelBuilder.Configurations.Add(new ORG_EmployeeMap());
            modelBuilder.Configurations.Add(new ORG_EmployeeDepartmentHistoryMap());
            modelBuilder.Configurations.Add(new ORG_ShiftMap());
            modelBuilder.Configurations.Add(new ORG_StoreMap());
            modelBuilder.Configurations.Add(new SYS_FunctionMap());
            modelBuilder.Configurations.Add(new SYS_MenuMap());
            modelBuilder.Configurations.Add(new SYS_MenuFunctionMap());
            modelBuilder.Configurations.Add(new SYS_ModuleMap());
            modelBuilder.Configurations.Add(new SYS_OrderRemindSettingMap());
            modelBuilder.Configurations.Add(new SYS_PrepaymentsSettingMap());
            modelBuilder.Configurations.Add(new SYS_SysSettingMap());
            modelBuilder.Configurations.Add(new SYS_TaxRateCategoryMap());
            modelBuilder.Configurations.Add(new SYS_UnitMap());
            modelBuilder.Configurations.Add(new SYS_VoucherDataMap());
            modelBuilder.Configurations.Add(new SYS_VoucherEncodingRuleMap());
        }
    }
}
