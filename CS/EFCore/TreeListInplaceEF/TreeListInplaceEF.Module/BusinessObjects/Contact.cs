using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace MySolution.Module.BusinessObjects;

[DefaultClassOptions]
public class Contact : BaseObject {
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual int Age { get; set; }
    public virtual DateTime BirthDate { get; set; }
}