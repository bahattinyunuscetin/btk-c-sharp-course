public class databaselogger extends baselogger {
public void add(){
    System.out.println("müşteri eklendi");
    databaselogger logger = new databaselogger();
    logger.log("log mesajı");
}
}
