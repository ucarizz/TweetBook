﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetBook.Domain;

namespace TweetBook.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();

        Post GetPostById(Guid guid);

        bool UpdatePost(Post PostToUpdate);
    }
}
