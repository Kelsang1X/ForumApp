﻿namespace Entities;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int UserId { get; set; }
    public int SubforumId { get; set; }
    public int commentId { get; set; }
    public string commentBody{ get; set; }
}