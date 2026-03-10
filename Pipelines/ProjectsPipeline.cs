using Statiq.Common; // importing the common types and interfaces from the Statiq framework 
using Statiq.Core; 
// importing the core types and interfaces from the Statiq framework. It defines 
// the pipelines and modules that are used to process content in a Statiq application.

namespace MyStaticSite.Pipelines
{
    public class ProjectsPipeline : Pipeline // defining a new pipeline class called ProjectsPipeline that inherits from the Pipeline class in the Statiq framework.
    {
        public ProjectsPipeline() // constructor for the ProjectsPipeline class. This is where you would typically define the modules that make up the pipeline, such as content readers, transformers, and writers.
        {
            Dependencies.Add("Content"); 
            // adding a dependency on the "Content" pipeline, which means that 
            // this pipeline will run after the "Content" pipeline has completed.
            
        }
    }
}