// ---------------- Constants ----------------

const string buildTask = "build";
string targetArg = Argument( "target", buildTask );

FilePath sln = File( "./src/ActivityPub.Models.sln" );

// ---------------- Targets ----------------

Task( buildTask )
.Does(
    ( context ) =>
    {
        var settings = new DotNetBuildSettings
        {
        };

        DotNetBuild( sln.ToString(), settings );
    }
)
.Description( "Builds with Debug turned on." );

// ---------------- Run ----------------

RunTarget( targetArg );
