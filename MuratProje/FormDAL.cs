using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratProje
{
    public class FormDAL
    {
        kayitEntities db = new kayitEntities();

        public IEnumerable<Form> GetAllForm()
        {
            return db.Form;
        }
        public Form GetFormById(int id)
        {
            return db.Form.Find(id);
        }
        public Form CrateForm(Form form)
        {
            db.Form.Add(form);
            db.SaveChanges();
            return form;
        }

        public Form CrateForm(object form)
        {
            throw new NotImplementedException();
        }

        public Form UpdateForm (int id,Form form)
        {
            db.Entry(form).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return form;
        }
        public void DeleteForm(int id)
        {
            db.Form.Remove(db.Form.Find(id));
            db.SaveChanges();
        }

    }
}
