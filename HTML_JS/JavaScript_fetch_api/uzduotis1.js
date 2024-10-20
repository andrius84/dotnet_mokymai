const randomPage = Math.floor(Math.random() * 33) + 1;

async function getImages(randomPage) {
    try {
        const response = await fetch(`https://picsum.photos/v2/list?page=${randomPage}`);
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        const data = await response.json();
        showImages(data);
    } catch (error) {
        console.error('Error:', error);
    }
}

function showImages(images) {
    const container = document.getElementById('images-container');

    images.forEach((image) => {
        const img = document.createElement('img');
        img.src = image.download_url;
        img.style.width = '200px';
        img.style.height = '200px';
        img.style.objectFit = 'cover';
        img.style.margin = '10px';
        container.appendChild(img); 
    });
}

getImages(randomPage);
    
