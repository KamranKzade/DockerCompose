var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();



// docker compose stop  -- > calisan containeri dayandiririq.
// docker compose rm    -- > calismayan containerleri silmek ucun istifade edirik.
// docker compose up    -- > imagelarimizi 0dan build edir,Containerleri sifirdan olusturur 
//                           eyni zamanda containeri ise baslatir (attach formasinda).
// docker compose down  -- > Containerleri dayandirir ve ardiycan silir, eyni zamanda
//                           up ile bir yerde yaranan Volumelarda varsa onlarida silir.
// docker compose up -d -- > Containerleri de-attach olaraq yaradir.