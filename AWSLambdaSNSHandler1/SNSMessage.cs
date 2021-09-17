using Amazon.DynamoDBv2.DataModel;

namespace AWSLambdaSNSHandler1
{
    [DynamoDBTable("SNSTutorial")]
    public class SNSMessage
    {
        [DynamoDBHashKey]
        public string messageId { get; set; }
        [DynamoDBRangeKey]
        public string processedDate { get; set; } 
        public string messageBody { get; set; }
    }
}
