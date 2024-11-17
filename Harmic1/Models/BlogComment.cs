﻿using System;
using System.Collections.Generic;

namespace Harmic1.Models;

public partial class BlogComment
{
    public int CommentId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }
    public string? Image { get; set; }

/*nhin nay*/
    public DateTime? CreateDate { get; set; }

    public string? Detail { get; set; }

    public int? BlogId { get; set; }

    public bool IsActive { get; set; }

    public virtual Blog? Blog { get; set; }
}