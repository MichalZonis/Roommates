using Roommates.Models;

namespace Roommates.Logic
{
    public class ItemsLogic
    {
        public static int addItem(Item newItem)
        {
            using (var db = new ItemContext())
            {
                db.Items.Add(newItem);
                return db.SaveChanges();
            }
        }
    }
}
