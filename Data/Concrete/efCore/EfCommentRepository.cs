using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.efCore;
using BlogApp.Entity;


namespace BlogApp.Data.Concrete.efCore
{
    public class EfCommentRepository : ICommentRepository
    {

        private BlogContext _context;

        public EfCommentRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Comment> Comments => _context.Comments;

        public void CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

    }
}

