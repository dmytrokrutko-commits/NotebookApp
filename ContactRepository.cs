using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NotebookApp
{
   
    public class ContactRepository
    {
        private readonly string _filePath;
        private List<Contact> _contacts;

        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
{
    WriteIndented = true,
    Encoder       = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    Converters    = { new JsonStringEnumConverter() }
};

        public ContactRepository(string filePath = "contacts.json")
        {
            _filePath = filePath;
            _contacts = Load();
        }


        public List<Contact> GetAll() => new List<Contact>(_contacts);

        public Contact GetById(Guid id) =>
            _contacts.FirstOrDefault(c => c.Id == id);

       

        public void Add(Contact contact)
        {
            contact.CreatedAt    = DateTime.Now;
            contact.LastModified = DateTime.Now;
            _contacts.Add(contact);
            Save();
        }

        public void Update(Contact contact)
        {
            int idx = _contacts.FindIndex(c => c.Id == contact.Id);
            if (idx < 0) return;

            contact.LastModified = DateTime.Now;
            _contacts[idx] = contact;
            Save();
        }

        public void Delete(Guid id)
        {
            _contacts.RemoveAll(c => c.Id == id);
            Save();
        }

      

        public List<Contact> Search(string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern))
                return GetAll();

            string p = pattern.ToLower();

            return _contacts.Where(c =>
                Contains(c.LastName,           p) ||
                Contains(c.FirstName,          p) ||
                Contains(c.MiddleName,         p) ||
                Contains(c.Phone,              p) ||
                Contains(c.Email,              p) ||
                Contains(c.Address,            p) ||
                Contains(c.WorkPlace,          p) ||
                Contains(c.Position,           p) ||
                Contains(c.BusinessQualities,  p) ||
                Contains(c.Notes,              p) ||
                Contains(c.RelationTypeDisplay(), p) ||
                (c.BirthDate.HasValue &&
                    c.BirthDate.Value.ToString("dd.MM.yyyy").Contains(p))
            ).ToList();
        }


        public List<Contact> SortByName(List<Contact> contacts) =>
            contacts
                .OrderBy(c  => c.LastName)
                .ThenBy(c   => c.FirstName)
                .ThenBy(c   => c.MiddleName)
                .ToList();

        public List<Contact> SortByLastModified(List<Contact> contacts) =>
            contacts
                .OrderByDescending(c => c.LastModified)
                .ToList();

       

        public List<Contact> GetBirthdaysToday() =>
            _contacts.Where(c => c.HasBirthdayToday()).ToList();

   

        private static bool Contains(string source, string pattern) =>
            !string.IsNullOrEmpty(source) &&
            source.ToLower().Contains(pattern);

        private void Save()
        {
            string json = JsonSerializer.Serialize(_contacts, _jsonOptions);
            File.WriteAllText(_filePath, json);
        }

        private List<Contact> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Contact>();

            try
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<Contact>>(json, _jsonOptions)
                       ?? new List<Contact>();
            }
            catch
            {
                return new List<Contact>();
            }
        }
    }
}
