using System;
namespace Pluto.Models.Enums
{
    [Flags]
    public enum FormPrivilege{
        None = 0, 
        View=1,
        Create =2 ,
        Approve = 4,
        
    }

}