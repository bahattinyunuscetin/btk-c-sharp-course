public class customermaeger {
    private baselogger logger;
    public customermaeger(baselogger logger){
        this.logger= logger;
    }
    public static void add(){
        System.out.println("müşteri eklendi");
        this.logger.log("log mesajı");
    }

}
