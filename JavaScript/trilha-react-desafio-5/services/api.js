import axios from 'axios';

export const api  = axios.create({
    baseURL: 'https://ycdisbgqlbcsuzfttdvp.supabase.co/rest/v1/',
    headers: {
        apikey: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InljZGlzYmdxbGJjc3V6ZnR0ZHZwIiwicm9sZSI6ImFub24iLCJpYXQiOjE3Mjc3OTI2MTgsImV4cCI6MjA0MzM2ODYxOH0.FaCEWpPetuJqHg0T7OMJ8N-uwn2dU3GSK0gjGxCq4Go",
        authorization: "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InljZGlzYmdxbGJjc3V6ZnR0ZHZwIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTcyNzc5MjYxOCwiZXhwIjoyMDQzMzY4NjE4fQ.XjTeu92JW0rcWJEQlSlSSud0TC-hZQo5KQjFZR1zEoA"
    }
})