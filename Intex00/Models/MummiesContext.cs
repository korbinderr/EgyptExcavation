using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex00.Models
{
    public partial class MummiesContext : DbContext
    {
        public MummiesContext()
        {
        }

        public MummiesContext(DbContextOptions<MummiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Analysis> Analysis { get; set; }
        public virtual DbSet<AnalysisTextile> AnalysisTextile { get; set; }
        public virtual DbSet<Artifactfagelgamousregister> Artifactfagelgamousregister { get; set; }
        public virtual DbSet<ArtifactfagelgamousregisterBurialmain> ArtifactfagelgamousregisterBurialmain { get; set; }
        public virtual DbSet<Artifactkomaushimregister> Artifactkomaushimregister { get; set; }
        public virtual DbSet<ArtifactkomaushimregisterBurialmain> ArtifactkomaushimregisterBurialmain { get; set; }
        public virtual DbSet<Biological> Biological { get; set; }
        public virtual DbSet<BiologicalC14> BiologicalC14 { get; set; }
        public virtual DbSet<Bodyanalysischart> Bodyanalysischart { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Burialall> Burialall { get; set; }
        public virtual DbSet<Burialall1> Burialall1 { get; set; }
        public virtual DbSet<Burialall2> Burialall2 { get; set; }
        public virtual DbSet<Burialall3> Burialall3 { get; set; }
        public virtual DbSet<Burialall4> Burialall4 { get; set; }
        public virtual DbSet<Burialall5> Burialall5 { get; set; }
        public virtual DbSet<Burialall6> Burialall6 { get; set; }
        public virtual DbSet<Burialall7> Burialall7 { get; set; }
        public virtual DbSet<Burialmain> Burialmain { get; set; }
        public virtual DbSet<BurialmainBiological> BurialmainBiological { get; set; }
        public virtual DbSet<BurialmainBodyanalysischart> BurialmainBodyanalysischart { get; set; }
        public virtual DbSet<BurialmainCranium> BurialmainCranium { get; set; }
        public virtual DbSet<BurialmainTextile> BurialmainTextile { get; set; }
        public virtual DbSet<C14> C14 { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<ColorTextile> ColorTextile { get; set; }
        public virtual DbSet<Cranium> Cranium { get; set; }
        public virtual DbSet<Decoration> Decoration { get; set; }
        public virtual DbSet<DecorationTextile> DecorationTextile { get; set; }
        public virtual DbSet<Dimension> Dimension { get; set; }
        public virtual DbSet<DimensionTextile> DimensionTextile { get; set; }
        public virtual DbSet<Newsarticle> Newsarticle { get; set; }
        public virtual DbSet<Photodata> Photodata { get; set; }
        public virtual DbSet<PhotodataTextile> PhotodataTextile { get; set; }
        public virtual DbSet<Photoform> Photoform { get; set; }
        public virtual DbSet<Structure> Structure { get; set; }
        public virtual DbSet<StructureTextile> StructureTextile { get; set; }
        public virtual DbSet<Teammember> Teammember { get; set; }
        public virtual DbSet<Textile> Textile { get; set; }
        public virtual DbSet<Textilefunction> Textilefunction { get; set; }
        public virtual DbSet<TextilefunctionTextile> TextilefunctionTextile { get; set; }
        public virtual DbSet<Yarnmanipulation> Yarnmanipulation { get; set; }
        public virtual DbSet<YarnmanipulationTextile> YarnmanipulationTextile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=
database-5.cehg903c1efj.us-east-1.rds.amazonaws.com
;Port=5432;Database=Mummies;User Id=postgres;Password=adminadmin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Analysis>(entity =>
            {
                entity.ToTable("analysis");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Analysisid).HasColumnName("analysisid");

                entity.Property(e => e.Analysistype).HasColumnName("analysistype");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AnalysisTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainAnalysisid, e.MainTextileid })
                    .HasName("main$analysis_textile_pkey");

                entity.ToTable("analysis_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainAnalysisid })
                    .HasName("idx_main$analysis_textile_main$textile_main$analysis");

                entity.Property(e => e.MainAnalysisid).HasColumnName("main$analysisid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Artifactfagelgamousregister>(entity =>
            {
                entity.ToTable("artifactfagelgamousregister");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Coordinateset)
                    .HasColumnName("coordinateset")
                    .HasMaxLength(200);

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Photographed)
                    .HasColumnName("photographed")
                    .HasMaxLength(3);

                entity.Property(e => e.Registernum)
                    .HasColumnName("registernum")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ArtifactfagelgamousregisterBurialmain>(entity =>
            {
                entity.HasKey(e => new { e.MainArtifactfagelgamousregisterid, e.MainBurialmainid })
                    .HasName("main$artifactfagelgamousregister_burialmain_pkey");

                entity.ToTable("artifactfagelgamousregister_burialmain");

                entity.HasIndex(e => new { e.MainBurialmainid, e.MainArtifactfagelgamousregisterid })
                    .HasName("idx_main$artifactfagelgamousregister_burialmain");

                entity.Property(e => e.MainArtifactfagelgamousregisterid).HasColumnName("main$artifactfagelgamousregisterid");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");
            });

            modelBuilder.Entity<Artifactkomaushimregister>(entity =>
            {
                entity.ToTable("artifactkomaushimregister");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Currentlocation)
                    .HasColumnName("currentlocation")
                    .HasMaxLength(200);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensions)
                    .HasColumnName("dimensions")
                    .HasMaxLength(200);

                entity.Property(e => e.Entrydate).HasColumnName("entrydate");

                entity.Property(e => e.Excavatornum)
                    .HasColumnName("excavatornum")
                    .HasMaxLength(200);

                entity.Property(e => e.Finder)
                    .HasColumnName("finder")
                    .HasMaxLength(200);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(200);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(200);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(3);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(200);

                entity.Property(e => e.Provenance)
                    .HasColumnName("provenance")
                    .HasMaxLength(200);

                entity.Property(e => e.Qualityphotos)
                    .HasColumnName("qualityphotos")
                    .HasMaxLength(3);

                entity.Property(e => e.Rehousedto)
                    .HasColumnName("rehousedto")
                    .HasMaxLength(200);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ArtifactkomaushimregisterBurialmain>(entity =>
            {
                entity.HasKey(e => new { e.MainArtifactkomaushimregisterid, e.MainBurialmainid })
                    .HasName("main$artifactqumoshimregistrar_burialmain_pkey");

                entity.ToTable("artifactkomaushimregister_burialmain");

                entity.HasIndex(e => new { e.MainBurialmainid, e.MainArtifactkomaushimregisterid })
                    .HasName("idx_main$artifactkomaushimregister_burialmain");

                entity.Property(e => e.MainArtifactkomaushimregisterid).HasColumnName("main$artifactkomaushimregisterid");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");
            });

            modelBuilder.Entity<Biological>(entity =>
            {
                entity.ToTable("biological");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bagnumber).HasColumnName("bagnumber");

                entity.Property(e => e.Clusternumber).HasColumnName("clusternumber");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Initials)
                    .HasColumnName("initials")
                    .HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(2000);

                entity.Property(e => e.Previouslysampled)
                    .HasColumnName("previouslysampled")
                    .HasMaxLength(200);

                entity.Property(e => e.Racknumber).HasColumnName("racknumber");
            });

            modelBuilder.Entity<BiologicalC14>(entity =>
            {
                entity.HasKey(e => new { e.MainBiologicalid, e.MainC14id })
                    .HasName("main$biological_c14_pkey");

                entity.ToTable("biological_c14");

                entity.HasIndex(e => new { e.MainC14id, e.MainBiologicalid })
                    .HasName("idx_main$biological_c14_main$c14_main$biological");

                entity.Property(e => e.MainBiologicalid).HasColumnName("main$biologicalid");

                entity.Property(e => e.MainC14id).HasColumnName("main$c14id");
            });

            modelBuilder.Entity<Bodyanalysischart>(entity =>
            {
                entity.ToTable("bodyanalysischart");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CariesPeriodontalDisease)
                    .HasColumnName("caries_periodontal_disease")
                    .HasMaxLength(200);

                entity.Property(e => e.Estimatestature).HasColumnName("estimatestature");

                entity.Property(e => e.Femur)
                    .HasColumnName("femur")
                    .HasMaxLength(200);

                entity.Property(e => e.Femurheaddiameter)
                    .HasColumnName("femurheaddiameter")
                    .HasMaxLength(200);

                entity.Property(e => e.Femurlength).HasColumnName("femurlength");

                entity.Property(e => e.Gonion)
                    .HasColumnName("gonion")
                    .HasMaxLength(200);

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(200);

                entity.Property(e => e.Humerusheaddiameter)
                    .HasColumnName("humerusheaddiameter")
                    .HasMaxLength(200);

                entity.Property(e => e.Humeruslength).HasColumnName("humeruslength");

                entity.Property(e => e.Lambdoidsuture)
                    .HasColumnName("lambdoidsuture")
                    .HasMaxLength(200);

                entity.Property(e => e.MedicalIpRamus)
                    .HasColumnName("medical_ip_ramus")
                    .HasMaxLength(200);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(2000);

                entity.Property(e => e.Nuchalcrest)
                    .HasColumnName("nuchalcrest")
                    .HasMaxLength(200);

                entity.Property(e => e.Observations)
                    .HasColumnName("observations")
                    .HasColumnType("character varying");

                entity.Property(e => e.Orbitedge)
                    .HasColumnName("orbitedge")
                    .HasMaxLength(200);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(200);

                entity.Property(e => e.Parietalblossing).HasColumnName("parietalblossing");

                entity.Property(e => e.Perservationindex).HasColumnName("perservationindex");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.Sciaticnotch)
                    .HasColumnName("sciaticnotch")
                    .HasMaxLength(200);

                entity.Property(e => e.Sphenooccipitalsynchondrosis)
                    .HasColumnName("sphenooccipitalsynchondrosis")
                    .HasMaxLength(200);

                entity.Property(e => e.Squamossuture)
                    .HasColumnName("squamossuture")
                    .HasMaxLength(200);

                entity.Property(e => e.Subpubicangle)
                    .HasColumnName("subpubicangle")
                    .HasMaxLength(200);

                entity.Property(e => e.Supraorbitalridges)
                    .HasColumnName("supraorbitalridges")
                    .HasMaxLength(200);

                entity.Property(e => e.Toothattrition).HasColumnName("toothattrition");

                entity.Property(e => e.Tootheruptionageestimation).HasColumnName("tootheruptionageestimation");

                entity.Property(e => e.Ventralarc).HasColumnName("ventralarc");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.ToTable("books");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(300);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Burialall>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2).HasColumnName("burialnumber2");

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id8).HasColumnName("id8");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid2).HasColumnName("main$textileid2");

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected).HasColumnName("samplescollected");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest).HasColumnName("squareeastwest");

                entity.Property(e => e.Squarenorthsouth).HasColumnName("squarenorthsouth");

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(500);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Textileid).HasColumnName("textileid");

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasColumnType("numeric(10,2)");
            });

            modelBuilder.Entity<Burialall1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall1");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest).HasColumnName("squareeastwest");

                entity.Property(e => e.Squarenorthsouth).HasColumnName("squarenorthsouth");

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(500);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasColumnType("numeric(10,2)");
            });

            modelBuilder.Entity<Burialall2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall2");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(500);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest).HasColumnName("squareeastwest");

                entity.Property(e => e.Squarenorthsouth).HasColumnName("squarenorthsouth");

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(500);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasColumnType("numeric(10,2)");
            });

            modelBuilder.Entity<Burialall3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall3");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasMaxLength(500);

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasMaxLength(500);

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasMaxLength(500);

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasMaxLength(500);

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(500);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasMaxLength(500);

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasMaxLength(500);

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasMaxLength(500);

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(500);

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasMaxLength(500);

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasMaxLength(500);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(500);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(500);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasMaxLength(500);

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(500);

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(500);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Burialall4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall4");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasMaxLength(500);

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasMaxLength(500);

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasMaxLength(500);

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasMaxLength(500);

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(500);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasMaxLength(500);

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasMaxLength(500);

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasMaxLength(500);

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(500);

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasMaxLength(500);

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasMaxLength(500);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(500);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(500);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasMaxLength(500);

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(500);

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(2000);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Burialall5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall5");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasMaxLength(500);

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Area2)
                    .HasColumnName("area2")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber3)
                    .HasColumnName("burialnumber3")
                    .HasMaxLength(500);

                entity.Property(e => e.CariesPeriodontalDisease)
                    .HasColumnName("caries_periodontal_disease")
                    .HasMaxLength(1000);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexamination)
                    .HasColumnName("dateofexamination")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasMaxLength(500);

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(1000);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Dorsalpitting)
                    .HasColumnName("dorsalpitting")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest2)
                    .HasColumnName("eastwest2")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatestature)
                    .HasColumnName("estimatestature")
                    .HasMaxLength(500);

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasMaxLength(500);

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Femur)
                    .HasColumnName("femur")
                    .HasMaxLength(500);

                entity.Property(e => e.Femurheaddiameter)
                    .HasColumnName("femurheaddiameter")
                    .HasMaxLength(500);

                entity.Property(e => e.Femurlength)
                    .HasColumnName("femurlength")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Gonion)
                    .HasColumnName("gonion")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor2)
                    .HasColumnName("haircolor2")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(500);

                entity.Property(e => e.Humerusheaddiameter)
                    .HasColumnName("humerusheaddiameter")
                    .HasMaxLength(500);

                entity.Property(e => e.Humeruslegnth)
                    .HasColumnName("humeruslegnth")
                    .HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(500);

                entity.Property(e => e.Id10)
                    .HasColumnName("id10")
                    .HasMaxLength(500);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasMaxLength(500);

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasMaxLength(500);

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasMaxLength(500);

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(500);

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasMaxLength(500);

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasMaxLength(500);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(500);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(500);

                entity.Property(e => e.Lamboidsuture)
                    .HasColumnName("lamboidsuture")
                    .HasMaxLength(500);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasMaxLength(500);

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_ip_ramus")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth2)
                    .HasColumnName("northsouth2")
                    .HasMaxLength(500);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(2000);

                entity.Property(e => e.Nuchalcrest)
                    .HasColumnName("nuchalcrest")
                    .HasMaxLength(500);

                entity.Property(e => e.Observations)
                    .HasColumnName("observations")
                    .HasMaxLength(500);

                entity.Property(e => e.Orbitedge)
                    .HasColumnName("orbitedge")
                    .HasMaxLength(500);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Parietalblossing)
                    .HasColumnName("parietalblossing")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(500);

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preauricularsulcus)
                    .HasColumnName("preauricularsulcus")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservationindex)
                    .HasColumnName("preservationindex")
                    .HasMaxLength(500);

                entity.Property(e => e.Pubicbone)
                    .HasColumnName("pubicbone")
                    .HasMaxLength(500);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sciaticnotch)
                    .HasColumnName("sciaticnotch")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Sphenooccipitalsynchrondrosis)
                    .HasColumnName("sphenooccipitalsynchrondrosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Squamossuture)
                    .HasColumnName("squamossuture")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest2)
                    .HasColumnName("squareeastwest2")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth2)
                    .HasColumnName("squarenorthsouth2")
                    .HasMaxLength(500);

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.Subpubicangle)
                    .HasColumnName("subpubicangle")
                    .HasMaxLength(500);

                entity.Property(e => e.Supraorbitalridges)
                    .HasColumnName("supraorbitalridges")
                    .HasMaxLength(500);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(2000);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Tibia)
                    .HasColumnName("tibia")
                    .HasMaxLength(500);

                entity.Property(e => e.Toothattrition)
                    .HasColumnName("toothattrition")
                    .HasMaxLength(500);

                entity.Property(e => e.Tootheruption)
                    .HasColumnName("tootheruption")
                    .HasMaxLength(500);

                entity.Property(e => e.Tootheruptionageestimate)
                    .HasColumnName("tootheruptionageestimate")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Ventralarc)
                    .HasColumnName("ventralarc")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Zygomaticcrest)
                    .HasColumnName("zygomaticcrest")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Burialall6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("burialall6");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasMaxLength(500);

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Area2)
                    .HasColumnName("area2")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber3)
                    .HasColumnName("burialnumber3")
                    .HasMaxLength(500);

                entity.Property(e => e.CariesPeriodontalDisease)
                    .HasColumnName("caries_periodontal_disease")
                    .HasMaxLength(2000);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexamination)
                    .HasColumnName("dateofexamination")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasMaxLength(500);

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(2000);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Dorsalpitting)
                    .HasColumnName("dorsalpitting")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest2)
                    .HasColumnName("eastwest2")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatestature)
                    .HasColumnName("estimatestature")
                    .HasMaxLength(500);

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasMaxLength(500);

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Femur)
                    .HasColumnName("femur")
                    .HasMaxLength(500);

                entity.Property(e => e.Femurheaddiameter)
                    .HasColumnName("femurheaddiameter")
                    .HasMaxLength(500);

                entity.Property(e => e.Femurlength)
                    .HasColumnName("femurlength")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Gonion)
                    .HasColumnName("gonion")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor2)
                    .HasColumnName("haircolor2")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(500);

                entity.Property(e => e.Humerusheaddiameter)
                    .HasColumnName("humerusheaddiameter")
                    .HasMaxLength(500);

                entity.Property(e => e.Humeruslegnth)
                    .HasColumnName("humeruslegnth")
                    .HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(500);

                entity.Property(e => e.Id10)
                    .HasColumnName("id10")
                    .HasMaxLength(500);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasMaxLength(500);

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasMaxLength(500);

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasMaxLength(500);

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(500);

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasMaxLength(500);

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasMaxLength(500);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(500);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(500);

                entity.Property(e => e.Lamboidsuture)
                    .HasColumnName("lamboidsuture")
                    .HasMaxLength(500);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasMaxLength(500);

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_ip_ramus")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth2)
                    .HasColumnName("northsouth2")
                    .HasMaxLength(500);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(2000);

                entity.Property(e => e.Nuchalcrest)
                    .HasColumnName("nuchalcrest")
                    .HasMaxLength(500);

                entity.Property(e => e.Observations)
                    .HasColumnName("observations")
                    .HasMaxLength(500);

                entity.Property(e => e.Orbitedge)
                    .HasColumnName("orbitedge")
                    .HasMaxLength(500);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Parietalblossing)
                    .HasColumnName("parietalblossing")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(500);

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preauricularsulcus)
                    .HasColumnName("preauricularsulcus")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(2000);

                entity.Property(e => e.Preservationindex)
                    .HasColumnName("preservationindex")
                    .HasMaxLength(500);

                entity.Property(e => e.Pubicbone)
                    .HasColumnName("pubicbone")
                    .HasMaxLength(500);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sciaticnotch)
                    .HasColumnName("sciaticnotch")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Sphenooccipitalsynchrondrosis)
                    .HasColumnName("sphenooccipitalsynchrondrosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Squamossuture)
                    .HasColumnName("squamossuture")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest2)
                    .HasColumnName("squareeastwest2")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth2)
                    .HasColumnName("squarenorthsouth2")
                    .HasMaxLength(500);

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.Subpubicangle)
                    .HasColumnName("subpubicangle")
                    .HasMaxLength(500);

                entity.Property(e => e.Supraorbitalridges)
                    .HasColumnName("supraorbitalridges")
                    .HasMaxLength(500);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(2000);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Tibia)
                    .HasColumnName("tibia")
                    .HasMaxLength(500);

                entity.Property(e => e.Toothattrition)
                    .HasColumnName("toothattrition")
                    .HasMaxLength(500);

                entity.Property(e => e.Tootheruption)
                    .HasColumnName("tootheruption")
                    .HasMaxLength(500);

                entity.Property(e => e.Tootheruptionageestimate)
                    .HasColumnName("tootheruptionageestimate")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Ventralarc)
                    .HasColumnName("ventralarc")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Zygomaticcrest)
                    .HasColumnName("zygomaticcrest")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Burialall7>(entity =>
            {
                entity.HasKey(e => e.Keyid)
                    .HasName("constraint_name");

                entity.ToTable("burialall7");

                entity.Property(e => e.Keyid).HasColumnName("keyid");

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(500);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysisid)
                    .HasColumnName("analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.Analysistype)
                    .HasColumnName("analysistype")
                    .HasMaxLength(500);

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(500);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(500);

                entity.Property(e => e.Area2)
                    .HasColumnName("area2")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialid)
                    .HasColumnName("burialid")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber2)
                    .HasColumnName("burialnumber2")
                    .HasMaxLength(500);

                entity.Property(e => e.Burialnumber3)
                    .HasColumnName("burialnumber3")
                    .HasMaxLength(500);

                entity.Property(e => e.CariesPeriodontalDisease)
                    .HasColumnName("caries_periodontal_disease")
                    .HasMaxLength(2000);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Colorid)
                    .HasColumnName("colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(500);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(500);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(500);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexamination)
                    .HasColumnName("dateofexamination")
                    .HasMaxLength(500);

                entity.Property(e => e.Dateofexcavation)
                    .HasColumnName("dateofexcavation")
                    .HasMaxLength(500);

                entity.Property(e => e.Decorationid)
                    .HasColumnName("decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(500);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(2000);

                entity.Property(e => e.Dimensionid)
                    .HasColumnName("dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(500);

                entity.Property(e => e.Direction2)
                    .HasColumnName("direction2")
                    .HasMaxLength(500);

                entity.Property(e => e.Doneby)
                    .HasColumnName("doneby")
                    .HasMaxLength(500);

                entity.Property(e => e.Dorsalpitting)
                    .HasColumnName("dorsalpitting")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Eastwest2)
                    .HasColumnName("eastwest2")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasMaxLength(500);

                entity.Property(e => e.Estimatestature)
                    .HasColumnName("estimatestature")
                    .HasMaxLength(500);

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasMaxLength(500);

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(500);

                entity.Property(e => e.Femur)
                    .HasColumnName("femur")
                    .HasMaxLength(500);

                entity.Property(e => e.Femurheaddiameter)
                    .HasColumnName("femurheaddiameter")
                    .HasMaxLength(500);

                entity.Property(e => e.Femurlength)
                    .HasColumnName("femurlength")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(500);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(500);

                entity.Property(e => e.Gonion)
                    .HasColumnName("gonion")
                    .HasMaxLength(500);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(500);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(500);

                entity.Property(e => e.Haircolor2)
                    .HasColumnName("haircolor2")
                    .HasMaxLength(500);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(500);

                entity.Property(e => e.Humerus)
                    .HasColumnName("humerus")
                    .HasMaxLength(500);

                entity.Property(e => e.Humerusheaddiameter)
                    .HasColumnName("humerusheaddiameter")
                    .HasMaxLength(500);

                entity.Property(e => e.Humeruslegnth)
                    .HasColumnName("humeruslegnth")
                    .HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Id10)
                    .HasColumnName("id10")
                    .HasMaxLength(500);

                entity.Property(e => e.Id2)
                    .HasColumnName("id2")
                    .HasMaxLength(500);

                entity.Property(e => e.Id3)
                    .HasColumnName("id3")
                    .HasMaxLength(500);

                entity.Property(e => e.Id4)
                    .HasColumnName("id4")
                    .HasMaxLength(500);

                entity.Property(e => e.Id5)
                    .HasColumnName("id5")
                    .HasMaxLength(500);

                entity.Property(e => e.Id6)
                    .HasColumnName("id6")
                    .HasMaxLength(500);

                entity.Property(e => e.Id7)
                    .HasColumnName("id7")
                    .HasMaxLength(500);

                entity.Property(e => e.Id8)
                    .HasColumnName("id8")
                    .HasMaxLength(500);

                entity.Property(e => e.Id9)
                    .HasColumnName("id9")
                    .HasMaxLength(500);

                entity.Property(e => e.Lamboidsuture)
                    .HasColumnName("lamboidsuture")
                    .HasMaxLength(500);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(500);

                entity.Property(e => e.MainAnalysisid)
                    .HasColumnName("main$analysisid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainBurialmainid)
                    .HasColumnName("main$burialmainid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainColorid)
                    .HasColumnName("main$colorid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDecorationid)
                    .HasColumnName("main$decorationid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainDimensionid)
                    .HasColumnName("main$dimensionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainStructureid)
                    .HasColumnName("main$structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextilefunctionid)
                    .HasColumnName("main$textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid)
                    .HasColumnName("main$textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid2)
                    .HasColumnName("main$textileid2")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid3)
                    .HasColumnName("main$textileid3")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid4)
                    .HasColumnName("main$textileid4")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid5)
                    .HasColumnName("main$textileid5")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid6)
                    .HasColumnName("main$textileid6")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid7)
                    .HasColumnName("main$textileid7")
                    .HasMaxLength(500);

                entity.Property(e => e.MainTextileid8)
                    .HasColumnName("main$textileid8")
                    .HasMaxLength(500);

                entity.Property(e => e.MainYarnmanipulationid)
                    .HasColumnName("main$yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(500);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(500);

                entity.Property(e => e.MedialIpRamus)
                    .HasColumnName("medial_ip_ramus")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Northsouth2)
                    .HasColumnName("northsouth2")
                    .HasMaxLength(500);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(2000);

                entity.Property(e => e.Nuchalcrest)
                    .HasColumnName("nuchalcrest")
                    .HasMaxLength(500);

                entity.Property(e => e.Observations)
                    .HasColumnName("observations")
                    .HasMaxLength(2000);

                entity.Property(e => e.Orbitedge)
                    .HasColumnName("orbitedge")
                    .HasMaxLength(500);

                entity.Property(e => e.Osteophytosis)
                    .HasColumnName("osteophytosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Parietalblossing)
                    .HasColumnName("parietalblossing")
                    .HasMaxLength(500);

                entity.Property(e => e.Photographeddate)
                    .HasColumnName("photographeddate")
                    .HasMaxLength(500);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(500);

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(500);

                entity.Property(e => e.Preauricularsulcus)
                    .HasColumnName("preauricularsulcus")
                    .HasMaxLength(500);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(2000);

                entity.Property(e => e.Preservationindex)
                    .HasColumnName("preservationindex")
                    .HasMaxLength(500);

                entity.Property(e => e.Pubicbone)
                    .HasColumnName("pubicbone")
                    .HasMaxLength(500);

                entity.Property(e => e.Robust)
                    .HasColumnName("robust")
                    .HasMaxLength(500);

                entity.Property(e => e.Sampledate)
                    .HasColumnName("sampledate")
                    .HasMaxLength(500);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(500);

                entity.Property(e => e.Sciaticnotch)
                    .HasColumnName("sciaticnotch")
                    .HasMaxLength(500);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(500);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Sphenooccipitalsynchrondrosis)
                    .HasColumnName("sphenooccipitalsynchrondrosis")
                    .HasMaxLength(500);

                entity.Property(e => e.Squamossuture)
                    .HasColumnName("squamossuture")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(500);

                entity.Property(e => e.Squareeastwest2)
                    .HasColumnName("squareeastwest2")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(500);

                entity.Property(e => e.Squarenorthsouth2)
                    .HasColumnName("squarenorthsouth2")
                    .HasMaxLength(500);

                entity.Property(e => e.Structureid)
                    .HasColumnName("structureid")
                    .HasMaxLength(500);

                entity.Property(e => e.Subpubicangle)
                    .HasColumnName("subpubicangle")
                    .HasMaxLength(500);

                entity.Property(e => e.Supraorbitalridges)
                    .HasColumnName("supraorbitalridges")
                    .HasMaxLength(500);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(2000);

                entity.Property(e => e.Textilefunctionid)
                    .HasColumnName("textilefunctionid")
                    .HasMaxLength(500);

                entity.Property(e => e.Textileid)
                    .HasColumnName("textileid")
                    .HasMaxLength(500);

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(500);

                entity.Property(e => e.Tibia)
                    .HasColumnName("tibia")
                    .HasMaxLength(500);

                entity.Property(e => e.Toothattrition)
                    .HasColumnName("toothattrition")
                    .HasMaxLength(500);

                entity.Property(e => e.Tootheruption)
                    .HasColumnName("tootheruption")
                    .HasMaxLength(1000);

                entity.Property(e => e.Tootheruptionageestimate)
                    .HasColumnName("tootheruptionageestimate")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasMaxLength(500);

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasMaxLength(500);

                entity.Property(e => e.Value4)
                    .HasColumnName("value4")
                    .HasMaxLength(500);

                entity.Property(e => e.Value5)
                    .HasColumnName("value5")
                    .HasMaxLength(500);

                entity.Property(e => e.Ventralarc)
                    .HasColumnName("ventralarc")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(500);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(500);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(500);

                entity.Property(e => e.Yarnmanipulationid)
                    .HasColumnName("yarnmanipulationid")
                    .HasMaxLength(500);

                entity.Property(e => e.Zygomaticcrest)
                    .HasColumnName("zygomaticcrest")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Burialmain>(entity =>
            {
                entity.ToTable("burialmain");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adultsubadult)
                    .HasColumnName("adultsubadult")
                    .HasMaxLength(200);

                entity.Property(e => e.Ageatdeath)
                    .HasColumnName("ageatdeath")
                    .HasMaxLength(200);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(200);

                entity.Property(e => e.Burialid).HasColumnName("burialid");

                entity.Property(e => e.Burialmaterials)
                    .HasColumnName("burialmaterials")
                    .HasMaxLength(5);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(200);

                entity.Property(e => e.Clusternumber)
                    .HasColumnName("clusternumber")
                    .HasMaxLength(200);

                entity.Property(e => e.Dataexpertinitials)
                    .HasColumnName("dataexpertinitials")
                    .HasMaxLength(200);

                entity.Property(e => e.Dateofexcavation).HasColumnName("dateofexcavation");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(200);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(200);

                entity.Property(e => e.Excavationrecorder)
                    .HasColumnName("excavationrecorder")
                    .HasMaxLength(100);

                entity.Property(e => e.Facebundles)
                    .HasColumnName("facebundles")
                    .HasMaxLength(200);

                entity.Property(e => e.Fieldbookexcavationyear)
                    .HasColumnName("fieldbookexcavationyear")
                    .HasMaxLength(200);

                entity.Property(e => e.Fieldbookpage)
                    .HasColumnName("fieldbookpage")
                    .HasMaxLength(200);

                entity.Property(e => e.Goods)
                    .HasColumnName("goods")
                    .HasMaxLength(200);

                entity.Property(e => e.Hair)
                    .HasColumnName("hair")
                    .HasMaxLength(5);

                entity.Property(e => e.Haircolor)
                    .HasColumnName("haircolor")
                    .HasMaxLength(200);

                entity.Property(e => e.Headdirection)
                    .HasColumnName("headdirection")
                    .HasMaxLength(200);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasMaxLength(200);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(200);

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasMaxLength(5);

                entity.Property(e => e.Preservation)
                    .HasColumnName("preservation")
                    .HasMaxLength(200);

                entity.Property(e => e.Samplescollected)
                    .HasColumnName("samplescollected")
                    .HasMaxLength(200);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(200);

                entity.Property(e => e.Shaftnumber)
                    .HasColumnName("shaftnumber")
                    .HasMaxLength(200);

                entity.Property(e => e.Southtofeet)
                    .HasColumnName("southtofeet")
                    .HasMaxLength(200);

                entity.Property(e => e.Southtohead)
                    .HasColumnName("southtohead")
                    .HasMaxLength(200);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(200);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(200);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(2000);

                entity.Property(e => e.Westtofeet)
                    .HasColumnName("westtofeet")
                    .HasMaxLength(200);

                entity.Property(e => e.Westtohead)
                    .HasColumnName("westtohead")
                    .HasMaxLength(200);

                entity.Property(e => e.Wrapping)
                    .HasColumnName("wrapping")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BurialmainBiological>(entity =>
            {
                entity.HasKey(e => new { e.MainBurialmainid, e.MainBiologicalid })
                    .HasName("main$burialmain_biological_pkey");

                entity.ToTable("burialmain_biological");

                entity.HasIndex(e => new { e.MainBiologicalid, e.MainBurialmainid })
                    .HasName("idx_main$burialmain_biological_main$biological_main$burialmain");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainBiologicalid).HasColumnName("main$biologicalid");
            });

            modelBuilder.Entity<BurialmainBodyanalysischart>(entity =>
            {
                entity.HasKey(e => new { e.MainBurialmainid, e.MainBodyanalysischartid })
                    .HasName("main$burialmain_bodyanalysischart_pkey");

                entity.ToTable("burialmain_bodyanalysischart");

                entity.HasIndex(e => new { e.MainBodyanalysischartid, e.MainBurialmainid })
                    .HasName("idx_main$burialmain_bodyanalysischart");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainBodyanalysischartid).HasColumnName("main$bodyanalysischartid");
            });

            modelBuilder.Entity<BurialmainCranium>(entity =>
            {
                entity.HasKey(e => new { e.MainBurialmainid, e.MainCraniumid })
                    .HasName("main$burialmain_cranium_pkey");

                entity.ToTable("burialmain_cranium");

                entity.HasIndex(e => new { e.MainCraniumid, e.MainBurialmainid })
                    .HasName("idx_main$burialmain_cranium_main$cranium_main$burialmain");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainCraniumid).HasColumnName("main$craniumid");
            });

            modelBuilder.Entity<BurialmainTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainBurialmainid, e.MainTextileid })
                    .HasName("main$burialmain_textile_pkey");

                entity.ToTable("burialmain_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainBurialmainid })
                    .HasName("idx_main$burialmain_textile_main$textile_main$burialmain");

                entity.Property(e => e.MainBurialmainid).HasColumnName("main$burialmainid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<C14>(entity =>
            {
                entity.ToTable("c14");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agebp).HasColumnName("agebp");

                entity.Property(e => e.C14lab)
                    .HasColumnName("c14lab")
                    .HasMaxLength(200);

                entity.Property(e => e.Calendardate).HasColumnName("calendardate");

                entity.Property(e => e.Calibrateddateavg).HasColumnName("calibrateddateavg");

                entity.Property(e => e.Calibrateddatemax).HasColumnName("calibrateddatemax");

                entity.Property(e => e.Calibrateddatemin).HasColumnName("calibrateddatemin");

                entity.Property(e => e.Calibratedspan).HasColumnName("calibratedspan");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(2000);

                entity.Property(e => e.Foci)
                    .HasColumnName("foci")
                    .HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(2000);

                entity.Property(e => e.Questions)
                    .HasColumnName("questions")
                    .HasMaxLength(2000);

                entity.Property(e => e.Rack).HasColumnName("rack");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Tubenumber).HasColumnName("tubenumber");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("color");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Colorid).HasColumnName("colorid");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ColorTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainColorid, e.MainTextileid })
                    .HasName("main$color_textile_pkey");

                entity.ToTable("color_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainColorid })
                    .HasName("idx_main$color_textile_main$textile_main$color");

                entity.Property(e => e.MainColorid).HasColumnName("main$colorid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Cranium>(entity =>
            {
                entity.ToTable("cranium");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlphaCore)
                    .HasColumnName("alpha_core")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.BasionBregmaHeight)
                    .HasColumnName("basion_bregma_height")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.BasionNasion)
                    .HasColumnName("basion_nasion")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.BasionProsthionLength)
                    .HasColumnName("basion_prosthion_length")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.BizygomaticDiameter)
                    .HasColumnName("bizygomatic_diameter")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.InterobitalBreadth)
                    .HasColumnName("interobital_breadth")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.InterorbitalBreadth)
                    .HasColumnName("interorbital_breadth")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.InterorbitalSubtense)
                    .HasColumnName("interorbital_subtense")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.MaxNasalBreadth)
                    .HasColumnName("max_nasal_breadth")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.Maxcraniumbreadth)
                    .HasColumnName("maxcraniumbreadth")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.Maxcraniumlength)
                    .HasColumnName("maxcraniumlength")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.MidOrbitalBreadth)
                    .HasColumnName("mid_orbital_breadth")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.MidOrbitalSubtense)
                    .HasColumnName("mid_orbital_subtense")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.NasionProsthionUpper)
                    .HasColumnName("nasion_prosthion_upper")
                    .HasColumnType("numeric(28,8)");

                entity.Property(e => e.NasoAlphaSubtense)
                    .HasColumnName("naso_alpha__subtense")
                    .HasColumnType("numeric(28,8)");
            });

            modelBuilder.Entity<Decoration>(entity =>
            {
                entity.ToTable("decoration");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Decorationid).HasColumnName("decorationid");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DecorationTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainDecorationid, e.MainTextileid })
                    .HasName("main$decoration_textile_pkey");

                entity.ToTable("decoration_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainDecorationid })
                    .HasName("idx_main$decoration_textile_main$textile_main$decoration");

                entity.Property(e => e.MainDecorationid).HasColumnName("main$decorationid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Dimension>(entity =>
            {
                entity.ToTable("dimension");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dimensionid).HasColumnName("dimensionid");

                entity.Property(e => e.Dimensiontype)
                    .HasColumnName("dimensiontype")
                    .HasMaxLength(500);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<DimensionTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainDimensionid, e.MainTextileid })
                    .HasName("main$dimension_textile_pkey");

                entity.ToTable("dimension_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainDimensionid })
                    .HasName("idx_main$dimension_textile_main$textile_main$dimension");

                entity.Property(e => e.MainDimensionid).HasColumnName("main$dimensionid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Newsarticle>(entity =>
            {
                entity.ToTable("newsarticle");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasColumnType("character varying");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying");

                entity.Property(e => e.Urltoimage)
                    .HasColumnName("urltoimage")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Photodata>(entity =>
            {
                entity.ToTable("photodata");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(200);

                entity.Property(e => e.Photodataid).HasColumnName("photodataid");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PhotodataTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainPhotodataid, e.MainTextileid })
                    .HasName("main$photodata_textile_pkey");

                entity.ToTable("photodata_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainPhotodataid })
                    .HasName("idx_main$photodata_textile_main$textile_main$photodata");

                entity.Property(e => e.MainPhotodataid).HasColumnName("main$photodataid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Photoform>(entity =>
            {
                entity.ToTable("photoform");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(100);

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(10);

                entity.Property(e => e.Eastwest)
                    .HasColumnName("eastwest")
                    .HasMaxLength(1);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(200);

                entity.Property(e => e.Northsouth)
                    .HasColumnName("northsouth")
                    .HasMaxLength(1);

                entity.Property(e => e.Photodate).HasColumnName("photodate");

                entity.Property(e => e.Photographer)
                    .HasColumnName("photographer")
                    .HasMaxLength(100);

                entity.Property(e => e.Squareeastwest)
                    .HasColumnName("squareeastwest")
                    .HasMaxLength(100);

                entity.Property(e => e.Squarenorthsouth)
                    .HasColumnName("squarenorthsouth")
                    .HasMaxLength(5);

                entity.Property(e => e.Tableassociation)
                    .HasColumnName("tableassociation")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Structure>(entity =>
            {
                entity.ToTable("structure");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Structureid).HasColumnName("structureid");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<StructureTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainStructureid, e.MainTextileid })
                    .HasName("main$structure_textile_pkey");

                entity.ToTable("structure_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainStructureid })
                    .HasName("idx_main$structure_textile_main$textile_main$structure");

                entity.Property(e => e.MainStructureid).HasColumnName("main$structureid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Teammember>(entity =>
            {
                entity.ToTable("teammember");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bio)
                    .HasColumnName("bio")
                    .HasColumnType("character varying");

                entity.Property(e => e.Membername)
                    .HasColumnName("membername")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Textile>(entity =>
            {
                entity.ToTable("textile");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Burialnumber)
                    .HasColumnName("burialnumber")
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(200);

                entity.Property(e => e.Estimatedperiod)
                    .HasColumnName("estimatedperiod")
                    .HasMaxLength(200);

                entity.Property(e => e.Locale)
                    .HasColumnName("locale")
                    .HasMaxLength(200);

                entity.Property(e => e.Photographeddate).HasColumnName("photographeddate");

                entity.Property(e => e.Sampledate).HasColumnName("sampledate");

                entity.Property(e => e.Textileid).HasColumnName("textileid");
            });

            modelBuilder.Entity<Textilefunction>(entity =>
            {
                entity.ToTable("textilefunction");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Textilefunctionid).HasColumnName("textilefunctionid");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TextilefunctionTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainTextilefunctionid, e.MainTextileid })
                    .HasName("main$textilefunction_textile_pkey");

                entity.ToTable("textilefunction_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainTextilefunctionid })
                    .HasName("idx_main$textilefunction_textile");

                entity.Property(e => e.MainTextilefunctionid).HasColumnName("main$textilefunctionid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.Entity<Yarnmanipulation>(entity =>
            {
                entity.ToTable("yarnmanipulation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Angle)
                    .HasColumnName("angle")
                    .HasMaxLength(20);

                entity.Property(e => e.Component)
                    .HasColumnName("component")
                    .HasMaxLength(200);

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasMaxLength(100);

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(20);

                entity.Property(e => e.Manipulation)
                    .HasColumnName("manipulation")
                    .HasMaxLength(100);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(100);

                entity.Property(e => e.Ply)
                    .HasColumnName("ply")
                    .HasMaxLength(20);

                entity.Property(e => e.Thickness)
                    .HasColumnName("thickness")
                    .HasMaxLength(20);

                entity.Property(e => e.Yarnmanipulationid).HasColumnName("yarnmanipulationid");
            });

            modelBuilder.Entity<YarnmanipulationTextile>(entity =>
            {
                entity.HasKey(e => new { e.MainYarnmanipulationid, e.MainTextileid })
                    .HasName("main$yarnmanipulation_textile_pkey");

                entity.ToTable("yarnmanipulation_textile");

                entity.HasIndex(e => new { e.MainTextileid, e.MainYarnmanipulationid })
                    .HasName("idx_main$yarnmanipulation_textile");

                entity.Property(e => e.MainYarnmanipulationid).HasColumnName("main$yarnmanipulationid");

                entity.Property(e => e.MainTextileid).HasColumnName("main$textileid");
            });

            modelBuilder.HasSequence("some_other_name");

            modelBuilder.HasSequence("system$filedocument_fileid_mxseq");

            modelBuilder.HasSequence("system$queuedtask_sequence_mxseq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
