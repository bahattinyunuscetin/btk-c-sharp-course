public class Main {
    public  static void main(String[]   args) {
/*
  baselogger[] loggers =new baselogger[]{new filelogger, new emaillogger(), new databaselogger()};
  for (baselogger logger:loggers){
      logger.log("log mesajı");}
    }
*/
        customermaeger customermaneger = new customermaeger(new databaselogger());
        customermaeger.add();
        }