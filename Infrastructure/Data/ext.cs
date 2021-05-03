using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public static class Ext
    {
        public static void TryUpdateManyToMany<T, TKey>(this ApplicationDbContext db, IEnumerable<T> currentItems, IEnumerable<T> newItems, Func<T, TKey> getKey) where T : class
        {
            db.Set<T>().RemoveRange(currentItems.Except(newItems, getKey));
            db.Set<T>().AddRange(newItems.Except(currentItems, getKey));
        }

        public static IEnumerable<T> Except<T, TKey>(this IEnumerable<T> items, IEnumerable<T> other, Func<T, TKey> getKeyFunc)
        {
            return items
                .GroupJoin(other, getKeyFunc, getKeyFunc, (item, tempItems) => new { item, tempItems })
                .SelectMany(t => t.tempItems.DefaultIfEmpty(), (t, temp) => new { t, temp })
                .Where(t => ReferenceEquals(null, t.temp) || t.temp.Equals(default(T)))
                .Select(t => t.t.item);
        }

        // public static void Update()
        // {
        //     var model = db.UserProfile
        //                 .Include(x => x.UserCategories)
        //                 .FirstOrDefault(x => x.NoteId == note.NoteId);

        //     db.TryUpdateManyToMany(model.NoteTags, listOfNewTagIds
        //         .Select(x => new UserCategory
        //         {
        //             CategoryId = x,
        //             UserId = note.NoteId
        //         }), x => x.TagId);
        // }
    }
}