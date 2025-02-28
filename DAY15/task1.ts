interface Contact {
    id: number;
    name: string;
    email: string;
    phone: string;
  }
  
  class ContactManager {
    private contacts: Contact[] = [];
  
    addContact(contact: Contact): void {
      this.contacts.push(contact);
      console.log(`Contact added successfully: ${contact.name}`);
    }
  
    viewContacts(): Contact[] {
      return this.contacts;
    }
  
    modifyContact(id: number, updatedContact: Partial<Contact>): void {
      const contact = this.contacts.find(c => c.id === id);
      if (!contact) {
        console.error(`Error: Contact with ID ${id} not found.`);
        return;
      }
      Object.assign(contact, updatedContact);
      console.log(`Contact modified successfully: ${contact.name}`);
    }
  
    deleteContact(id: number): void {
      const index = this.contacts.findIndex(c => c.id === id);
      if (index === -1) {
        console.error(`Error: Contact with ID ${id} not found.`);
        return;
      }
      const deletedContact = this.contacts.splice(index, 1);
      console.log(`Contact deleted successfully: ${deletedContact[0].name}`);
    }
  }
  
  // Testing the ContactManager class
  const manager = new ContactManager();
  
  manager.addContact({ id: 1, name: "John Doe", email: "john@example.com", phone: "123-456-7890" });
  manager.addContact({ id: 2, name: "Jane Doe", email: "jane@example.com", phone: "987-654-3210" });
  
  console.log("Contact List:", manager.viewContacts());
  
  manager.modifyContact(1, { phone: "111-222-3333" });
  console.log("Updated Contact List:", manager.viewContacts());
  
  manager.deleteContact(2);
  console.log("Final Contact List:", manager.viewContacts());
  
  