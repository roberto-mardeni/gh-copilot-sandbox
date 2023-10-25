using Microsoft.EntityFrameworkCore;
using FluentValidation;

namespace Conference.Data;

// create speaker model with name, email and linkedin url
public class Speaker
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? LinkedIn { get; set; }
}

// create a speaker validator
public class SpeakerValidator : AbstractValidator<Speaker>
{
    public SpeakerValidator()
    {
        RuleFor(s => s.Name).NotEmpty();
        RuleFor(s => s.Email).NotEmpty().EmailAddress();
    }
}

// create speaker context
public class SpeakerContext : DbContext
{
    public SpeakerContext(DbContextOptions<SpeakerContext> options) : base(options) { }
    public DbSet<Speaker> Speakers => Set<Speaker>();
}
