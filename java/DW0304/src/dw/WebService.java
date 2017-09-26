package dw;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class WebService {

    private static ServerSocket s;

    public static void main(String[] args) throws IOException {
        s = new ServerSocket(8000);

        while (true) {
            Socket socket = s.accept();
            //Thread thread = new Thread(new Handler(socket));
            //thread.start();
        }

    }
}