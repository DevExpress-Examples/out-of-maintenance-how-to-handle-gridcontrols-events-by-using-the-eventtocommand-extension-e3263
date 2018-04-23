namespace EventToCommandExample.Models {
    public class SampleData {
        public virtual int ID { get; set; }
        public virtual string Text { get; set; }
        public virtual int Value { get; set; }
        public override string ToString() {
            return string.Format("{0} - {1} - {2}", ID, Text, Value);
        }
    }
}
