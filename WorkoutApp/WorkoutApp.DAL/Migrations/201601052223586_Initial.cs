namespace WorkoutApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ExerciseId = c.Int(nullable: false, identity: true),
                        MuscleGroup = c.String(),
                        ExerciseName = c.String(),
                        WorkoutSession_WorkoutSessionId = c.Int(),
                    })
                .PrimaryKey(t => t.ExerciseId)
                .ForeignKey("dbo.WorkoutSessions", t => t.WorkoutSession_WorkoutSessionId)
                .Index(t => t.WorkoutSession_WorkoutSessionId);
            
            CreateTable(
                "dbo.ExerciseSets",
                c => new
                    {
                        ExerciseSetId = c.Int(nullable: false, identity: true),
                        ExerciseSetWeight = c.Int(nullable: false),
                        ExerciseSetReps = c.Int(nullable: false),
                        Exercise_ExerciseId = c.Int(),
                    })
                .PrimaryKey(t => t.ExerciseSetId)
                .ForeignKey("dbo.Exercises", t => t.Exercise_ExerciseId)
                .Index(t => t.Exercise_ExerciseId);
            
            CreateTable(
                "dbo.WorkoutSessions",
                c => new
                    {
                        WorkoutSessionId = c.Int(nullable: false, identity: true),
                        SessionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WorkoutSessionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exercises", "WorkoutSession_WorkoutSessionId", "dbo.WorkoutSessions");
            DropForeignKey("dbo.ExerciseSets", "Exercise_ExerciseId", "dbo.Exercises");
            DropIndex("dbo.ExerciseSets", new[] { "Exercise_ExerciseId" });
            DropIndex("dbo.Exercises", new[] { "WorkoutSession_WorkoutSessionId" });
            DropTable("dbo.WorkoutSessions");
            DropTable("dbo.ExerciseSets");
            DropTable("dbo.Exercises");
        }
    }
}
