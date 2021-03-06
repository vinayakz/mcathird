import java.net.*;
import java.io.*;
import java.util.*;


public class RCEClient {
    public static void main(String[] args){
        Socket client;
        InputStream is;
        OutputStream os;
        DataOutputStream dos;

        Scanner scan = new Scanner(System.in);
        String cmd;
        
        try{
            client = new Socket("localhost", 7313);
            System.out.println("Connected to server: " + client.getInetAddress());
            System.out.println("Enter the command to execute remotely");
            cmd = scan.nextLine();
            
            is = client.getInputStream();
            os = client.getOutputStream();
            
            dos = new DataOutputStream(os);
            dos.writeUTF(cmd);
            
            int read;
            byte[] bytes = new byte[1024 * 4];
            while((read = is.read(bytes)) > 0){
                String res = new String(bytes);
                System.out.print(res);
            }
            os.flush();
            client.close();
            
        }catch(IOException e){
            System.out.println(e.getMessage());
        }
    }
}