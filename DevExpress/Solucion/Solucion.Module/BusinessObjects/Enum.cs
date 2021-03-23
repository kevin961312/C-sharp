using DevExpress.Persistent.Base;

namespace MySolution.Module.BusinessObjects
{
    public enum TitleOfCourtesy
    {
        Dr,
        Miss,
        Mr,
        Mrs,
        Ms
    };

    public enum DocumentType
    {
        SourceCode = 1,
        Tests = 2,
        Documentation = 3,
        Diagrams = 4,
        ScreenShots = 5,
        Unknown = 6
    };
    public enum Priority
    {
        [ImageName("State_Priority_Low")]
        Low = 0,
        [ImageName("State_Priority_Normal")]
        Normal = 1,
        [ImageName("State_Priority_High")]
        High = 2
    }
}