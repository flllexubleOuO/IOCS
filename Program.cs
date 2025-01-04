using IOCS.IOCS;

IOCFactory iOCFactory = new IOCFactory();

Student s =  (Student)iOCFactory.GetObject("IOCS.IOCS.Student");

s.Study();